using OssUpload.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WOA.src;

namespace OssUpload
{
    
    /// <summary>
    /// 这里放业务代码
    /// </summary>
    public partial class Form1
    {
        private void uploadFile()
        {
            //上传文件
            if (selectedFile == null)
            {
                MessageBox.Show("不存在的文件，请重新选择", "提示", MessageBoxButtons.OK);
            }
            buttonUpload.Enabled = false;
            buttonChoiceFile.Enabled = false;
            string path = OssContants.OSSPATH[comboBox1.Text] != null ? OssContants.OSSPATH[comboBox1.Text].ToString() : "";
            string res = OssUtils.upload(path, selectedFile);
            if (res != null)
            {
                res = OssConfig.BucketDomain + res;
                Logger.Instance.Info(res);
                processControl1.complete();
                MessageBox.Show("上传成功！点击确认后自动复制到剪切板", "上传结果", MessageBoxButtons.OK);
                Clipboard.SetText(res);

                //清空已经上传的选择文件，防止重复上传
                buttonUpload.Enabled = false;
                selectedFile = null;
            }
            else
            {
                MessageBox.Show("上传失败！请查看失败原因进行重试，多次失败请联系管理员", "上传结果", MessageBoxButtons.OK);
            }
            buttonChoiceFile.Enabled = true;
        }

        private string selectFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "选择一个文件上传";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return dialog.FileName;
            }
            return null;
        }
    }
}
