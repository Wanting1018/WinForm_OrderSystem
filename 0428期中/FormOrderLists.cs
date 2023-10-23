using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace _0428期中
{
    public partial class FormOrderLists : Form
    {
        public string 訂購人資訊 = "";

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        List<int> list訂單總價 = new List<int>();
        public FormOrderLists()
        {
            InitializeComponent();
        }

        private void FormOrderLists_Load(object sender, EventArgs e)
        {
            //資料庫↓
            scsb.DataSource = @".";
            scsb.InitialCatalog = "my_db";
            scsb.IntegratedSecurity = true;


            lbl訂購人資料.Text = $"訂購人：{GlobalVar.訂購人資訊}";

            foreach (ArrayList 訂購單品 in GlobalVar.list訂購品項資料)
            {
                string 品項名稱 = (string)訂購單品[0];
                //將「訂購單品」中的第一個項目轉換成字串，並且存放在名為「品項名稱」的變數中。這個程式碼假設「訂購單品」是一個陣列或清單，第一個項目的資料型別可能是任意的，因此需要進行強制轉換成字串型別。

                int 單價 = (int)訂購單品[1];
                int 數量 = (int)訂購單品[2];
                int 品項總價 = (int)訂購單品[3];
                string 甜度 = (string)訂購單品[4];
                string 冰塊 = (string)訂購單品[5];
                string 加料 = (string)訂購單品[6];

                string strFormat = "{0}   {1}元   數量：{2}   品項總價：{3}元  {4}  {5}  {6}";
                string str單品訂購資訊 = string.Format(strFormat, 品項名稱, 單價, 數量, 品項總價, 甜度, 冰塊, 加料);
                /* 
                品項名稱：{0}
                單價：{1}
                數量：{2}
                品項總價：{3}
                甜度：{4}
                冰塊：{5}
                加料：{6}
                */

                listBox訂購品項列表.Items.Add(str單品訂購資訊);

            }

            計算訂單總價();
        }

        void 計算訂單總價()
        {
            int 訂單總價 = 0;

            foreach (ArrayList 訂購單品 in GlobalVar.list訂購品項資料)
            {
                //複製上面的foreach迴圈

                string 品項名稱 = (string)訂購單品[0];
                int 品項總價 = (int)訂購單品[3];

                訂單總價 += 品項總價;

            }

            if ((GlobalVar.is買購物袋 == true) && (GlobalVar.list訂購品項資料.Count > 0))
            {
                訂單總價 += 2;
                lbl買購物袋.Visible = true;
                lbl買購物袋.Text = "買購物袋";

            }
            else
            {
                lbl買購物袋.Text = "";
            }

            if (GlobalVar.is外帶 == true)
            {
                lbl外帶.Text = "外帶";
            }
            else
            {
                lbl外帶.Text = "內用";
            }

            lbl訂單總價.Text = String.Format("訂單總價：{0}元", 訂單總價);
            list訂單總價.Add(訂單總價);
        }

        private void btn清除所有品項_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("您確定要清除所有品項嗎？", "清除所有品項確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            listBox訂購品項列表.Items.Clear();
            GlobalVar.list訂購品項資料.Clear();

            計算訂單總價();
        }

        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            //單選
            if (listBox訂購品項列表.SelectedIndex >= 0)
            {
                int select選擇品項 = listBox訂購品項列表.SelectedIndex;
                GlobalVar.list訂購品項資料.RemoveAt(select選擇品項);
                listBox訂購品項列表.Items.RemoveAt(select選擇品項);

                計算訂單總價();
            }
            else
            {
                MessageBox.Show("請選擇要移除的品項");
            }
        }

        private void btn訂購完成_Click(object sender, EventArgs e)
        {
            string str購物車明細 = "";

            foreach (ArrayList 訂購單品 in GlobalVar.list訂購品項資料)
            {
                string 品項名稱 = (string)訂購單品[0];
                int 單價 = (int)訂購單品[1];
                int 數量 = (int)訂購單品[2];
                int 品項總價 = (int)訂購單品[3];
                string 甜度 = (string)訂購單品[4];
                string 冰塊 = (string)訂購單品[5];
                string 加料 = (string)訂購單品[6];

                string strFormat = "{0} {1}元 數量：{2} 品項總價：{3}元 {4} {5} {6}";
                string str單品訂購資訊 = string.Format(strFormat, 品項名稱, 單價, 數量, 品項總價, 甜度, 冰塊, 加料);

                str購物車明細 += $"{品項名稱} 單價：{單價}元， 數量：{數量} ";
            }

            if (listBox訂購品項列表.Items.Count > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "insert into OrderDetails values ( @CustomerName, @OrderDetail, @TotalPrice, @OrderTime);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@CustomerName", GlobalVar.訂購人資訊.ToString());
                cmd.Parameters.AddWithValue("@OrderDetail", str購物車明細);
                cmd.Parameters.AddWithValue("@TotalPrice", list訂單總價[0]);
                cmd.Parameters.AddWithValue("@OrderTime", DateTime.Now);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("謝謝光臨！歡迎下次再來");

                Console.WriteLine($"資料異動成功，影響{rows}筆資料");

            }
            else
            {
                MessageBox.Show("購物車內沒有東西，請將品項加入購物車！");
            }
        }

        private void btn關閉表單_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void FormOrderLists_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult R = MessageBox.Show("您確定要關閉嗎？", "關閉表單確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // "您確定要關閉表單?" 內容
            //  "關閉表單確認"  標題
            // UI物件 sender
            // e事件

            if (R == DialogResult.Yes)
            {
                e.Cancel = false;// 取消事件(FormClosing不會繼續執行)
                // 要不要取消 【關閉】 的這個事件   ---->  不要取消，意思就是 【要關閉】

                計算訂單總價();
            }
            else
            {
                e.Cancel = true;// 否，取消
            }
        }
    }
}
