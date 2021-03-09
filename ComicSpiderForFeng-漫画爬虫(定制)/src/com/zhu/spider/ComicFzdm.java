package com.zhu.spider;


import com.zhu.utils.DownloadUtils;
import com.zhu.utils.HtmlSearchUtils;

import java.io.*;
import java.util.ArrayList;

/**
 * 专门下载风之动漫网漫画
 *
 */
public class ComicFzdm {
//	String myini = "src/com/zhu/net/spider/ComicFzdm_GateMan.txt";
//	String savePath = "进击的巨人/";
//	String comicNum = "39/";
	
	String myini = "src/com/zhu/spider/ComicFzdm.txt";
	String comicNum = "2/";
	
	//保存的目录
	String savePath = "D:/Onepiece/";
	
	//基本配置，一般不需要更改
	String[] regexMainPage = new String[] {"<a href=\"[0-9a-zA-Z/]+\" title="};
	String preUrl = "https://manhua.fzdm.com/";
	String midUrl = "index_";
	String backUrl = ".html";
	String[] regexs = new String[] { "<a href=\".*?\"", "[0-9a-zA-Z]+/{1}" };
	String[] regexs2 = new String[] { "mhurl=\".*?.jpg\"", "([0-9/a-z]*).jpg" };
	String picPreUrl = "http://p1.manhuapan.com";

	static int threadNum = 8;
	static int sleepTime = 3000;

	Mythread[] threads = new Mythread[threadNum];

	public static void main(String[] args) throws Exception {
		ComicFzdm comicFzdm = new ComicFzdm();
//		comicFzdm.searchMainPage();
//		comicFzdm.reverseIni();
		comicFzdm.download();
	}

	
	public void searchMainPage() throws Exception {
		String url = preUrl + comicNum;
		
		HtmlSearchUtils.searchFromPage(url, regexs, myini);
		System.out.println("检索目标url到配置文件完成！");
	}
	
	public void reverseIni() throws Exception {
		File oldFile = new File(myini);
		File newFile = new File(myini+".bak");
		BufferedReader reader = new BufferedReader(new InputStreamReader(new FileInputStream(oldFile)));
		BufferedWriter writer = new BufferedWriter(new OutputStreamWriter(new FileOutputStream(newFile)));
		ArrayList<String> list = new ArrayList<String>();
		String content = null;
		while((content=reader.readLine())!=null) {
			list.add(content);
		}
		
		for (int i = list.size()-1; i >= 0; i--) {
			writer.write(list.get(i)+"\r\n");
		}
		reader.close();
		writer.close();
		
		oldFile.delete();
		newFile.renameTo(oldFile);
		
		System.out.println("配置文件反转结束");
	}
	
	public void download() throws Exception {
		ComicFzdm dp = new ComicFzdm();
		// 初始化线程数据
		for (int i = 0; i < threadNum; i++) {
			dp.threads[i] = dp.new Mythread("突击小队"+i+"号");
		}
		// 从文件读取章节url，便于后面拼接
		InputStreamReader inputStreamReader = new InputStreamReader(new FileInputStream(dp.myini));
		BufferedReader bufferedReader = new BufferedReader(inputStreamReader);
		String content;
		while ((content = bufferedReader.readLine()) != null) {
			int free;
			while ((free = dp.getFreeThread()) == -1) // 若所有线程都很处于激活状态，则等待空闲线程出现
				Thread.sleep(sleepTime);
			dp.threads[free].setComicChapter(content);
			dp.threads[free].start();
		}
		bufferedReader.close();
	}


	public void searchChapter(String comicChapter) {
		
		String[] url = new String[20];
		String threadName =Thread.currentThread().getName();

		for (int i = 0; i < url.length; i++) {
			url[i] = preUrl + comicNum + comicChapter + midUrl + i + backUrl;
			System.out.println(threadName + "尝试下载" + comicChapter + "的第" + i + "页面的图片...");
			String picUrl = null;
			try {
				picUrl = picPreUrl + "/" + HtmlSearchUtils.searchFromPage(url[i], regexs2);
			} catch (IOException e) {
				System.out.println(threadName + "获取"+url[i]+"失败");
				break;
			}
			try {
				boolean isDown = DownloadUtils.download(picUrl, savePath + comicChapter + i + ".jpg");
				if (!isDown)
					System.out.println(comicChapter + "的第" + i + "页面的图片已存在");
//				else 
//					System.out.println(threadName+ "成功下载了" + comicChapter + "的第" + i + "页面的图片");
			} catch (IOException e) {
				System.out.println(threadName+"不能获取"+picUrl);
			}
		}
	}

	private int getFreeThread() {
		for (int i = 0; i < threadNum; i++) {
			if (threads[i].getState().equals(Thread.State.NEW))
				return i;
			else if (threads[i].getState().equals(Thread.State.TERMINATED)) {
				threads[i] = new Mythread("突击小队"+i+"号");
				return i;
			}
		}
		return -1;
	}

	class Mythread extends Thread {
		private String comicChapter;
		
		public Mythread(String name) {
			super(name);
		}

		public String getComicChapter() {
			return comicChapter;
		}
		public void setComicChapter(String comicChapter) {
			this.comicChapter = comicChapter;
		}

		@Override
		public void run() {
			searchChapter(comicChapter);
		}
	}
}
