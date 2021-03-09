using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WechatOfficialAccountUtils.utils
{
    class WechatServiceUtils
    {
        public static string GetAccessToken(string appid, string appsecret)
        {
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}", appid, appsecret);
            return HttpUtils.Get(url);
        }

        public static string CreateMenu(string accessToken, string menuContent)
        {
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/menu/create?access_token={0}", accessToken);
            return HttpUtils.Post(url, menuContent);
        }

        public static string QueryMenu(string accessToken)
        {
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/get_current_selfmenu_info?access_token={0}", accessToken);
            return HttpUtils.Get(url);
        }

        public static string DeleteMenu(string accessToken)
        {
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/menu/delete?access_token={0}", accessToken);
            return HttpUtils.Get(url);
        }

        //public static string CreateTmpResource(string accessToken, string urlPath) {
        //}

        public static string GetResourceCount(string accessToken) {
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/material/get_materialcount?access_token={0}", accessToken);
            return HttpUtils.Get(url);
        }

        public static string GetResourceList(string accessToken, string type, int offset, int count) {
            string content = "{\"type\":\""+type+ "\",\"offset\":" + offset + ",\"count\":" + count + "}";
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/material/batchget_material?access_token={0}", accessToken);
            return HttpUtils.Post(url, content);
        }

        public static string SendTemplate(string accessToken, string templateId, string openId, string urls, string data)
        {
            string allData = "{\"touser\":\"" + openId + "\",\"template_id\":\"" + templateId + "\",\"url\":\"" + urls + "\",\"topcolor\":\"#FF0000\",\"data\":" + data + "}";
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/message/template/send?access_token={0}", accessToken);
            return HttpUtils.Post(url, allData);
        }
    }
}
