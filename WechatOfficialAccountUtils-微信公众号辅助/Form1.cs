using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WechatOfficialAccountUtils.src;
using WechatOfficialAccountUtils.utils;

namespace WechatOfficialAccountUtils {
    public partial class Form1 : Form {
        private string appid;
        private string appsecret;
        private string accessToken;

        private Logger logger;
        public Form1() {
            InitializeComponent();
            //tabControl1.Enabled = false;
            logger = new Logger(textBoxLog);
        }

        private void buttonGetAccessToken_Click(object sender, EventArgs e) {
            this.appid = textBoxAppid.Text;
            this.appsecret = textBoxAppSecret.Text;
            string result = WechatServiceUtils.GetAccessToken(appid, appsecret);
            logger.info(result);

            JObject jo = (JObject)JsonConvert.DeserializeObject(result);
            if (jo["access_token"] != null) {
                this.accessToken = jo["access_token"].ToString();
                //tabControl1.Enabled = true;
                logger.info("成功获取accessToken：" + accessToken);
            }
        }
        #region 菜单管理
        private void buttonCreateMenu_Click(object sender, EventArgs e) {
            string menuStr = textBoxMenu.Text;
            string result = WechatServiceUtils.CreateMenu(accessToken, menuStr);
            logger.info(result);
        }

        private void buttonDeleteMenu_Click(object sender, EventArgs e) {
            string result = WechatServiceUtils.DeleteMenu(accessToken);
            logger.info(result);
        }

        private void buttonQueryMenu_Click(object sender, EventArgs e) {
            string result = WechatServiceUtils.QueryMenu(accessToken);
            logger.info(result);

            textBoxMenu.Text = result;
        }

        private void buttonCountResource_Click(object sender, EventArgs e) {
            string result = WechatServiceUtils.GetResourceCount(accessToken);
            logger.info(result);
            JObject jo = (JObject)JsonConvert.DeserializeObject(result);
            if (jo["image_count"] != null) {
                labelImageCount.Text = jo["image_count"].ToString();
                labelNewsCount.Text = jo["news_count"].ToString();
                labelVideoCount.Text = jo["video_count"].ToString();
                labelVoiceCount.Text = jo["voice_count"].ToString();
            }

        }
        #endregion



        #region 素材管理
        
        private string resourceType;

        private void resourseListPageChange()
        {
            resourceListClear();
            if (resourceType == null) return;
            string result = WechatServiceUtils.GetResourceList(accessToken, resourceType, pageControl1.Current, pageControl1.PageSize);
            logger.info(result);

            JObject jo = (JObject)JsonConvert.DeserializeObject(result);
            if (jo["item"] != null)
            {
                // 数据展示
                JArray items = JArray.Parse(jo["item"].ToString());
                for (int i = 0; i < items.Count; i++)
                {
                    JToken jToken = items[i];

                    ListViewItem item = new ListViewItem();
                    if (this.resourceType != "news")
                    {
                        item.Text = jToken["name"].ToString();
                        item.SubItems.Add(jToken["media_id"].ToString());
                        item.SubItems.Add(jToken["update_time"].ToString());
                        item.SubItems.Add(jToken["url"].ToString());
                    }
                    else
                    {
                        item.Text = jToken["content"].ToString();
                        item.SubItems.Add(jToken["media_id"].ToString());
                        item.SubItems.Add(jToken["update_time"].ToString());
                    }
                    listView1.Items.Add(item);
                }
                // 数据统计
                pageControl1.Total = int.Parse(jo["total_count"].ToString());
            }
            Console.WriteLine(pageControl1.Current + "," + pageControl1.Total + "," + pageControl1.PageSize);
        }

        private void resourceListClear()
        {
            listView1.Items.Clear();
        }

        private void buttonQueryResource_Click(object sender, EventArgs e)
        {
            pageControl1.Init(resourseListPageChange);
            pageControl1.change();
        }

        private void radioButtonImage_CheckedChanged(object sender, EventArgs e) {
            this.resourceType = "image";
        }

        private void radioButtonVideo_CheckedChanged(object sender, EventArgs e) {
            this.resourceType = "video";
        }

        private void radioButtonVoice_CheckedChanged(object sender, EventArgs e) {
            this.resourceType = "voice";
        }

        private void radioButtonNews_CheckedChanged(object sender, EventArgs e) {
            this.resourceType = "news";
        }


        private void listViewClick(object sender, EventArgs e) {
            string text = "";
            foreach (ListViewItem item in listView1.SelectedItems) {
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems) {
                    text = text + "\t" + subItem.Text;
                }
                text += "\n";
            }
            Clipboard.SetText(text);
        }


        private void buttonUploadResource_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void buttonLogClear_Click(object sender, EventArgs e)
        {
            textBoxLog.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string templateId = textBoxTemplateId.Text;
            string url = textBoxTemplateUrl.Text;
            string content = textBoxTemplateContent.Text;
            string users = textBoxTemplateUsers.Text;
            //移除换行
            string[] userArr = users.Split(new String[] { "\r\n"}, StringSplitOptions.RemoveEmptyEntries);

            if (templateId == "" || url==""|| content==""|| userArr.Length == 0)
            {
                logger.info("请填写完整的信息");
            }
            else {
                int successNumber = 0;
                foreach (string openid in userArr)
                {
                    if (openid == null || openid == "")
                        continue;
                    string result = WechatServiceUtils.SendTemplate(accessToken, templateId, openid, url, content);
                    logger.info(result);
                    //查看成功发送的用户
                    JObject jObject = JObject.Parse(result);
                    if (jObject["errcode"].ToObject<int>() == 0)
                        successNumber++;
                }
                logger.info("一共发送了" + userArr.Length + "条模板消息，其中有" + successNumber + "条成功接口");
            }

        }

        private void buttonMenuHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://developers.weixin.qq.com/doc/offiaccount/Custom_Menus/Creating_Custom-Defined_Menu.html");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Template_Message_Interface.html");
        }

        private void buttonAccessTokenCopy_Click(object sender, EventArgs e)
        {
            if (this.accessToken == null)
            {
                logger.info("请先填写appid和appsecret！");
            } else { 
                Clipboard.SetText(this.accessToken);
                logger.info("复制accessToken成功！");
            }
        }
    }

}
