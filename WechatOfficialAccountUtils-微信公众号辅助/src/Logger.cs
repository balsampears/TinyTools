using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WechatOfficialAccountUtils.src
{
    class Logger
    {
        private TextBox textBox;
        private bool isRemeber = true;
        public Logger(TextBox textBox)
        {
            this.textBox = textBox;
        }
        public Logger(TextBox textBox, bool isRemeber)
        {
            this.textBox = textBox;
            this.isRemeber = isRemeber;
        }
        public void info(string info)
        {
            if (isRemeber)
                textBox.Text = info + "\r\n" + textBox.Text;
            else
                textBox.Text = info + "\r\n";
            Console.WriteLine(info);
        }
    }
}
