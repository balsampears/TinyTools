using System;
using System.Windows.Forms;
using Aliyun.OSS;

namespace OssUpload
{
    public partial class ProcessControl : UserControl
    {
        public int ProcessValue
        {
            get
            {
                return progressBar1.Value;
            }
            set
            {
                progressBar1.Value = value;
                label1.Text = value + "%";
            }
        }

        public ProcessControl()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 进度条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void change(object sender, StreamTransferProgressArgs args)
        {
            int value = (int)(args.TransferredBytes * 100 / args.TotalBytes);
            ProcessValue = Math.Max(value - 1, 0);  //限制到99%
            //System.Console.WriteLine("ProgressCallback - Progress: {0}%, TotalBytes:{1}, TransferredBytes:{2} ",
            //    args.TransferredBytes * 100 / args.TotalBytes, args.TotalBytes, args.TransferredBytes);
        }

        public void complete()
        {
            ProcessValue = 100;
        }
    }
}
