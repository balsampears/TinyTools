using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.OSS;
using System;
using System.IO;
using WOA.src;

namespace OssUpload.src
{
    class OssUtils
    {
        public delegate void ProcessDelegate(object render, StreamTransferProgressArgs args);

        public static ProcessDelegate ThisProcessDelegate { get; set; }

        private static OssClient ossClient;

        private static bool isLoading = false;

        public static void Init()
        {
            ossClient = new OssClient(OssConfig.Endpoint, OssConfig.AccessKeyId, OssConfig.AccessKeySecret);
            //ossClient = new OssClient(OssConfig.Endpoint, accessKeyId, accessKeySecret, securityToken);
        }

        public static string upload(string ossPath, string fileName)
        {
            if (isLoading)
            {
                Logger.Instance.Info("正在上传中，请稍等~");
                return null;
            }
            if (ossPath == null || ossPath == "")
            {
                ossPath = "";
            }
            else
            {
                ossPath += "/";
            }
            isLoading = true;
            Init();

            string uuid = System.Guid.NewGuid().ToString();
            string fileType = fileName.Substring(fileName.LastIndexOf("."));
            string objectName = ossPath + uuid + fileType;
            string res = putObject(objectName, fileName);

            isLoading = false;
            return res;
        }

        /// <summary>
        /// 普通上传
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="fileName"></param>
        private static string putObject(string objectName, string fileName)
        {
            FileStream file = null;
            try
            {
                file = File.Open(fileName, FileMode.Open);
                PutObjectRequest request = new PutObjectRequest(OssConfig.Bucket, objectName, file);
                // 进度条
                request.StreamTransferProgress += streamProgressCallback;
                ossClient.PutObject(request);

                return objectName;
            }
            catch (Exception ex)
            {
                //string res = string.Format("上传失败, {0}", ex.Message);
                //return res;
                Logger.Instance.Info("上传失败," + ex.Message);
                return null;
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
        }

        /// <summary>
        /// 进度条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private static void streamProgressCallback(object sender, StreamTransferProgressArgs args)
        {
            ThisProcessDelegate?.Invoke(sender, args);
            //System.Console.WriteLine("ProgressCallback - Progress: {0}%, TotalBytes:{1}, TransferredBytes:{2} ",
            //    args.TransferredBytes * 100 / args.TotalBytes, args.TotalBytes, args.TransferredBytes);
        }


        private static string accessKeyId;
        private static string accessKeySecret;
        private static string securityToken;
        /// <summary>
        /// 获取STS临时授权访问令牌
        /// </summary>
        /// <returns></returns>
        public static void getSecurityToken()
        {
            try
            {
                DefaultProfile profile = DefaultProfile.GetProfile("", OssConfig.AccessKeyId, OssConfig.AccessKeySecret);
                DefaultAcsClient client = new DefaultAcsClient(profile);
                AssumeRoleRequest request = new AssumeRoleRequest();
                request.Method = Aliyun.Acs.Core.Http.MethodType.POST;
                request.RoleArn = OssConfig.StsRoleArn;
                request.RoleSessionName = OssConfig.StsRoleSessionName;
                request.DurationSeconds = 900;

                AssumeRoleResponse response = client.GetAcsResponse(request);
                accessKeyId = response.Credentials.AccessKeyId;
                accessKeySecret = response.Credentials.AccessKeySecret;
                securityToken = response.Credentials.SecurityToken;

                Console.WriteLine("Expiration: " + response.Credentials.Expiration);
                Console.WriteLine("Access Key Id: " + response.Credentials.AccessKeyId);
                Console.WriteLine("Access Key Secret: " + response.Credentials.AccessKeySecret);
                Console.WriteLine("Security Token: " + response.Credentials.SecurityToken);
                Console.WriteLine("RequestId: " + response.RequestId);
            }
            catch(ClientException e)
            {
                Console.WriteLine("Failed：");
                Console.WriteLine("Error code: " + e.ErrorCode);
                Console.WriteLine("Error message: " + e.ErrorMessage);
                Console.WriteLine("RequestId: " + e.RequestId);
            }
        }


    }
}
