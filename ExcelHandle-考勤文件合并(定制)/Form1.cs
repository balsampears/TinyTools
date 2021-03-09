using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelHandle.src;
using NPOI;

namespace ExcelHandle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string filenameDing;
        private string filenameHe;


        private void buttonImportDing_Click(object sender, EventArgs e)
        {
            openDialog(out filenameDing, buttonImportDing);
        }

        private void buttonImportHe_Click(object sender, EventArgs e)
        {
            openDialog(out filenameHe, buttonImportHe);
        }

        /// <summary>
        /// 选择文件
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="button"></param>
        private void openDialog(out string filename, Button button)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择考勤表";
            dialog.Filter = "表格文件|*.xls;*.xlsx";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = dialog.FileName;
                button.Text = "已选择";
                Console.WriteLine(filename);
                Console.WriteLine(getFileSuffiex(filename));
            } else
            { 
                filename = "";
            }
        }

        /// <summary>
        /// 获取文件后缀名
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        private string getFileSuffiex(string filename)
        {
            return filename.Substring(filename.IndexOf(".")+1);
        }

        /// <summary>
        /// 开始生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.filenameDing == null || this.filenameHe == null)
            {
                MessageBox.Show("请先选择文件！","错误警告");
                return;
            }
            DataTable dtDing = NpoiHelper.Import(filenameDing, getFileSuffiex(filenameDing));
            DataTable dtHe = NpoiHelper.Import(filenameHe, getFileSuffiex(filenameHe));

            for (int i = 3; i < dtDing.Rows.Count; i++)
            {
                DataRow dr = dtDing.Rows[i];
                this.RowHandleDingToHe(dtHe, dr);
                for (int j = 0; j < dr.ItemArray.Length; j++)
                {
                    Console.Out.Write(j + "=>" + dr.ItemArray[j].ToString() + ",");
                }
                Console.Out.WriteLine();
            }
            //保存到桌面
            saveFile(dtHe);
        }

        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="dtHe"></param>
        private static void saveFile(DataTable dtHe)
        {
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string saveFile = dir + "\\合并考勤表.xls";
            NpoiHelper.Export(dtHe, "合并考勤表", saveFile);
            MessageBox.Show("生成成功！文件已经保存在" + saveFile,"消息提示");
            Console.Out.WriteLine("生成成功");
        }

        private void RowHandleDingToHe(DataTable dtHe, DataRow drDing)
        {
            string nothing = "暂无";
            DataRow drHe = dtHe.NewRow();
            drHe[Constants.He.Name] = drDing.ItemArray[Constants.Ding.Name];
            //drHe[Constants.He.Quanqin] = nothing;
            drHe[Constants.He.Chuqin] = GetAndCheckRowItem(drDing, Constants.Ding.Chuqin);
            //drHe[Constants.He.Jiejiari] = nothing;
            drHe[Constants.He.Waiqin] = GetAndCheckRowItem(drDing, Constants.Ding.Waiqin);

            //drHe[Constants.He.Yichang] = nothing;
            drHe[Constants.He.Chuchai] = GetAndCheckRowItem(drDing, Constants.Ding.Chuchai);
            drHe[Constants.He.Shijia] = GetAndCheckRowItem(drDing, Constants.Ding.Shijia);
            drHe[Constants.He.Nianjia] =GetAndCheckRowItem(drDing, Constants.Ding.Nianjia);
            drHe[Constants.He.Bingjia] = GetAndCheckRowItem(drDing, Constants.Ding.Bingjia) ;

            drHe[Constants.He.Hunjia] = GetAndCheckRowItem(drDing, Constants.Ding.Hunjia);
            drHe[Constants.He.Shengyujia] =GetAndCheckRowItem(drDing, Constants.Ding.Shengyujia);
            drHe[Constants.He.Huchanjia] = GetAndCheckRowItem(drDing, Constants.Ding.Huchanjia);
            drHe[Constants.He.Furujia] = GetAndCheckRowItem(drDing, Constants.Ding.Furujia);
            drHe[Constants.He.Sangjia] = GetAndCheckRowItem(drDing, Constants.Ding.Sangjia);

            //drHe[Constants.He.Gongshangjia] = nothing;
            //drHe[Constants.He.Liuchanjia] = nothing;
            //drHe[Constants.He.Tanqinjia] = nothing;
            drHe[Constants.He.Kuanggong] = GetAndCheckRowItem(drDing, Constants.Ding.Kuanggong);
            drHe[Constants.He.Tiaoxiu] = GetAndCheckRowItem(drDing, Constants.Ding.Tiaoxiu);

            drHe[Constants.He.Chidao5] = "右边的迟到累计时长";
            drHe[Constants.He.Zaotui5] = GetAndCheckRowItem(drDing, Constants.Ding.Chidao);
            drHe[Constants.He.Chidaoleiji] = GetAndCheckRowItem(drDing, Constants.Ding.Chidaoleiji);
            drHe[Constants.He.Zaotuileiji] = GetAndCheckRowItem(drDing, Constants.Ding.Zaotuileiji);

            drHe[Constants.He.Pingshijiaban] =GetAndCheckRowItem(drDing, Constants.Ding.Pingshijiaban);
            drHe[Constants.He.Zhoumojiaban] = GetAndCheckRowItem(drDing, Constants.Ding.Zhoumojiaban);
            drHe[Constants.He.Fadingjiejiari] =GetAndCheckRowItem(drDing, Constants.Ding.Fadingjiejiari);
            drHe[Constants.He.Liudaitiaoxiu] = GetAndCheckRowItem(drDing, Constants.Ding.Liudaitiaoxiu);
            dtHe.Rows.Add(drHe);
        }
        
        /// <summary>
        /// 获取一行
        /// </summary>
        /// <param name="drDing"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private static object GetAndCheckRowItem(DataRow drDing, int index)
        {
            return drDing.ItemArray[index].ToString() != "" ? drDing.ItemArray[index] : 0;
        }

    }
}
