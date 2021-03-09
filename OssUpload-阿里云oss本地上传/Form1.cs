using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.OSS;
using OssUpload.src;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using WOA.src;

namespace OssUpload
{
    public partial class Form1 : Form
    {

        private string selectedFile = null;

        public Form1()
        {
            InitializeComponent();
            Init();
            Logger.Instance.Init(textBoxLog, false);
        }

        private void Init()
        {
            foreach (var key in OssContants.OSSPATH.Keys)
            {
                comboBox1.Items.Add(key.ToString());
            }
            comboBox1.SelectedIndex = 2;
            ProcessControl.CheckForIllegalCrossThreadCalls = false;
            OssUtils.ThisProcessDelegate = processControl1.change;
        }


        private void buttonUpload_Click(object sender, EventArgs e)
        {
            ThreadStart threadStart = new ThreadStart(uploadFile);
            Thread thread = new Thread(threadStart);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }


        private void buttonChoiceFile_Click(object sender, EventArgs e)
        {
            selectedFile = selectFile();
            if (selectedFile != null)
            {
                buttonUpload.Enabled = true;
            }
        }

        private void textBoxLog_Click(object sender, EventArgs e)
        {
            string text = textBoxLog.Text;
            if (text != null && text != "")
                Clipboard.SetText(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OssUtils.getSecurityToken();
        }
    }
}
