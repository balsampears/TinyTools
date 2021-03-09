using System;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;

namespace WechatOfficialAccountUtils
{
    public partial class PageControl : UserControl
    {
        public PageControl()
        {
            InitializeComponent();
            this.Enabled = false;
        }
        // 点击按钮时发生的委托
        public delegate void ChangeDelegate();

        public int PageSize { get; set; }
        public int Total { set; get; } = 0;
        public int Current { get; set; } = 0;
        public int Pages
        {
            get
            {
                if (PageSize == 0) return 0;
                return Total / PageSize + 1;
            }
        }


        private ChangeDelegate thisDelegate;

        public void Init(ChangeDelegate thisDelegate)
        {
            this.thisDelegate = thisDelegate;
            this.PageSize = int.Parse(comboBox1.SelectedItem.ToString());
            this.Enabled = true;
            ObjectCollection list = comboBox1.Items;
            switchButtonStatus();
        }
        public void Reset(int current, int size)
        {
            this.Current = current;
            this.PageSize = size;
        }
        public void Reset(int current, int size, int total)
        {
            this.Current = current;
            this.PageSize = size;
            this.Total = total;
        }

        /// <summary>
        /// 调用委托方法，同时更新本控件状态
        /// </summary>
        public void change()
        {
            thisDelegate();
            switchButtonStatus();
        }

        private void switchButtonStatus()
        {
            if (Current == 0)
            {
                buttonLast.Enabled = false;
            } else
            {
                buttonLast.Enabled = true;
            }
            if (Current + PageSize >= Total)
            {
                buttonNext.Enabled = false;
            }
            else
            {
                buttonNext.Enabled = true;
            }

        }


        private void buttonLast_Click(object sender, EventArgs e)
        {
            Current = Math.Max(Current - PageSize, 0);
            change();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Current += PageSize;
            change();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PageSize = int.Parse(comboBox1.SelectedItem.ToString());
            change();
        }
    }
}
