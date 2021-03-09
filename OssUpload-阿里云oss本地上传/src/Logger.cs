using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WOA.src
{
    class Logger
    {
        #region 单例
        private static Logger instance;
        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }
        private Logger() { }

        private TextBox textBox;
        private bool isRemeber = true;
        #endregion

        public void Init(TextBox textBox, bool isRemeber)
        {
            this.textBox = textBox;
            this.isRemeber = isRemeber;
        }

        public void Info(string info)
        {
            if (isRemeber)
                textBox.Text = info + "\r\n" + textBox.Text;
            else
                textBox.Text = info + "\r\n";
            Console.WriteLine(info);
        }
    }
}
