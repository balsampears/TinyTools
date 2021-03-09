package com.zhu.utils;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.MalformedURLException;
import java.net.URL;
import java.net.URLConnection;

import javax.net.ssl.HttpsURLConnection;

/**
 * 根据url地址，直接下载文件
 * @author zhuu
 *
 */
public class DownloadUtils {

	/**
	 * 字节流下载文件
	 * 
	 * @param path
	 * @param filename
	 * @throws MalformedURLException
	 * @throws IOException
	 * @throws FileNotFoundException
	 */
	public static boolean download(String urls, String filename)
			throws MalformedURLException, IOException, FileNotFoundException {
		checkFilename(filename);
		
		URL url = new URL(urls);
		checkCertificates(url);

		URLConnection connect = url.openConnection();
		InputStream inputStream = connect.getInputStream();
		File file = new File(filename);

		//判断本地文件和下载文件的大小是否相同,如果相同则直接放弃这次下载
		if (checkFileIdentical(connect, file))
			return false;
		
		//写出数据
		FileOutputStream fileOutputStream = new FileOutputStream(file);
		int len;
		byte[] bs = new byte[1024];
		while ((len = inputStream.read(bs)) != -1) {
			fileOutputStream.write(bs, 0, len);
		}
		fileOutputStream.close();
		inputStream.close();
		return true;
	}
	/**
	 * 	判断本地文件和下载文件的大小是否相同
	 * @param connect
	 * @param file
	 * @return
	 */
	private static boolean checkFileIdentical(URLConnection connect, File file) {
		if(file.exists()) {
			String localSize = String.valueOf(file.length());
			String netSize = connect.getHeaderField("Content-Length");
			if (localSize.equals(netSize))
				return true;
		}
		return false;
	}
	
	/**
	 * 用于判断文件目录是否存在，不存在就生成目录
	 * 
	 * @param filename
	 */
	public static void checkFilename(String filename) {
		File file = new File(filename);
		File pFile = file.getParentFile();
		if (pFile != null)
			pFile.mkdirs();
	}
	
	/**
	 * 解决https证书问题
	 * @param url
	 */
	public static void checkCertificates(URL url) {
		if (url.getProtocol().equals("https")) {
			try {
				CertificatesUtils.trustAllHttpsCertificates();
			} catch (Exception e) {
				e.printStackTrace();
			}
			HttpsURLConnection.setDefaultHostnameVerifier(CertificatesUtils.hv);
		}
	}
}
