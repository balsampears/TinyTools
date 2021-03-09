using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OssUpload.src
{
    class OssConfig
    {
        public static string AccessKeyId = "";

        public static string AccessKeySecret = "";

        public static string Endpoint = "oss-cn-shenzhen.aliyuncs.com";

        public static string Bucket = "supergen-test-assets";

        /// <summary>
        /// 生成bucket的前缀地址，可能用了OSS加速
        /// </summary>
        public static string BucketDomain = "https://supergen-test-assets.oss-cn-shenzhen.aliyuncs.com/";

        /// <summary>
        /// RAM角色的ARN
        /// </summary>
        public static string StsRoleArn = "";

        /// <summary>
        /// 这个只是表示给STS的区分应用的标识
        /// </summary>
        public static string StsRoleSessionName = "ossUploadUtils";

        public static string StsEndpoint = "sts.cn-shenzhen.aliyuncs.com";
    }
}
