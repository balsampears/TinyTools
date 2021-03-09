package com.zhu.utils;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.URL;
import java.net.URLConnection;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * 从网页过滤并获取地址
 * @author zhuu
 *
 */
public class HtmlSearchUtils {
	/**
	 * 从url获取页面，再从页面进行多次筛选，将所有符合的url放入文件中
	 * @param url
	 * @param regexs
	 * @param filename
	 * @return
	 * @throws IOException
	 */
	public static String searchFromPage(String url, String[] regexs, String filename) throws IOException {
		URL urls = new URL(url);

		DownloadUtils.checkCertificates(urls);
		URLConnection conn = urls.openConnection();
		InputStream inStream = conn.getInputStream();
		BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(inStream));
		
		//删除原来的文件
		if(filename!=null) {
			File file = new File(filename);
			if (file.exists())
				file.delete();
		}
		// 筛选数据找到对应URL
		String contents;
		while ((contents = bufferedReader.readLine()) != null) {
			if (filename != null)
				loopMatcher(0, regexs, contents, filename);
			else {
				String realUrl = loopMatcher(0, regexs, contents);
				if (realUrl != null)
					return realUrl;
			}
		}
		return null;
	}
	/**
	 * 从url获取页面，再从页面进行多次筛选，获取第一个符合的url
	 * 
	 * @param url
	 * @param regexs
	 * @return
	 * @throws IOException
	 */
	public static String searchFromPage(String url, String[] regexs) throws IOException {
		return searchFromPage(url, regexs, null);
	}
	/**
	 * 递归调用，多次匹配规则，将所有符合的放入文件中
	 * @param loopCount   递归调用的深度
	 * @param regexs	     正则规则数组
	 * @param content     筛选的内容
	 * @param filename    需要放入的文件名
	 * @throws IOException
	 */
	public static void loopMatcher(int loopCount, String[] regexs, String content, String filename) throws IOException {
		Matcher nowMatch = startMatch(content, regexs[loopCount]);
		while (nowMatch.find()) {
			if (loopCount == regexs.length - 1) {
				FileOutputStream fileOutputStream = new FileOutputStream(filename, true);
				byte[] bs = (nowMatch.group() + "\r\n").getBytes();
				fileOutputStream.write(bs);
				fileOutputStream.close();
			}
			else {
				loopMatcher(loopCount+1, regexs, nowMatch.group(), filename);
			}
		}
	}
	/**
	 * 递归调用，多次匹配，将第一个符合的返回出来
	 * 
	 * @param loopCount
	 * @param regexs
	 * @param content
	 * @return
	 */
	public static String loopMatcher(int loopCount, String[] regexs, String content) {
		Matcher nowMatch = startMatch(content, regexs[loopCount]);
		if (nowMatch.find()) {
			if (loopCount < regexs.length - 1)
				return loopMatcher(++loopCount, regexs, nowMatch.group());
			else
				return nowMatch.group();
		} else
			return null;
	}

	/**
	 * 进行一次正则匹配
	 * 
	 * @param content
	 * @param compile
	 * @return
	 */
	private static Matcher startMatch(String content, Pattern compile) {
		Matcher matcher = compile.matcher(content);
		return matcher;
	}

	private static Matcher startMatch(String content, String regex) {
		Pattern compile = Pattern.compile(regex);
		return startMatch(content, compile);
	}
}
