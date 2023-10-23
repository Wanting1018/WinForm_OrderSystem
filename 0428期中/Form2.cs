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
    public partial class Form2 : Form
    {

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();        //SQL連線字串產生器

        List<string> list冰塊 = new List<string>();
        List<string> list甜度 = new List<string>();
        List<string> list加料品項 = new List<string>();
        List<int> list加料價格 = new List<int>();

        int 所選數量 = 0;
        int 所選單價 = 0;
        int 所選品項總價 = 0;

        string 所選冰塊 = "";
        string 所選甜度 = "";
        string 所選品項 = "";
        string 所選加料 = "";

        public int SelectID = 0;

        List<int> listPid = new List<int>();
        List<string> listProductName = new List<string>();
        List<int> listPrice = new List<int>();
        List<string> listPdesc = new List<string>();
        List<string> listPImage = new List<string>();
        List<string> listPcategory = new List<string>();

        string strDBConnectionString = "";


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //冰塊
            list冰塊.Add("");
            list冰塊.Add("正常冰");
            list冰塊.Add("少冰");
            list冰塊.Add("微冰");
            list冰塊.Add("去冰");

            //甜度
            list甜度.Add("");
            list甜度.Add("正常甜");
            list甜度.Add("半糖");
            list甜度.Add("微糖");
            list甜度.Add("無糖");

            //加料
            list加料品項.Add("不加料");
            list加料品項.Add("珍珠");
            list加料品項.Add("波霸");
            list加料品項.Add("芋圓");
            list加料品項.Add("冰淇淋");
            list加料品項.Add("布丁");

            list加料價格.Add(0);
            list加料價格.Add(10);
            list加料價格.Add(10);
            list加料價格.Add(15);
            list加料價格.Add(20);
            list加料價格.Add(20);

            //加料品項價格與冰塊及甜度品項 加入到comboBox中
            foreach (string item in list冰塊)
            {
                combo冰塊.Items.Add(item);
            }

            foreach (string item in list甜度)
            {
                combo甜度.Items.Add(item);
            }

            for (int i = 0; i < list加料品項.Count; i += 1)
            {
                string strItemA = $"{list加料品項[i]}    {list加料價格[i]}元";
                combo加料.Items.Add(strItemA);
            }

            //表單預設值
            combo甜度.SelectedIndex = 0;
            所選甜度 = list甜度[combo甜度.SelectedIndex];

            combo冰塊.SelectedIndex = 0;
            所選冰塊 = list冰塊[combo冰塊.SelectedIndex];

            combo加料.SelectedIndex = 0;
            所選加料 = list加料品項[combo加料.SelectedIndex];

            txt數量.Text = 1.ToString();
            所選數量 = 1;

            chk買購物袋.Checked = false;
            GlobalVar.is買購物袋 = false;

            //資料庫↓
            scsb.DataSource = @".";
            scsb.InitialCatalog = "my_db";
            scsb.IntegratedSecurity = true;
            //GlobalVar.strDBConnectionString = scsb.ConnectionString;
            

            //產生品項列表DGV();
            讀取商品資料庫();
            顯示listview商品列表();
        }

        void 讀取商品資料庫()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select top 200 * from products;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;

            while (reader.Read() == true)
            {
                listPid.Add((int)reader["id"]);
                listProductName.Add((string)reader["pname"]);
                listPrice.Add((int)reader["price"]);
                listPdesc.Add((string)reader["pdesc"]);
                string image_name = (string)reader["pimage"];
                listPcategory.Add((string)reader["pcategory"]);

                string 完整圖檔路徑 = $"{GlobalVar.image_dir}\\{image_name}";  //圖檔目錄+圖檔名稱
                // 應該把路徑定義成類別變數 (也可以定義成全域變數)
                //  \\ 因為\是特殊符號
                Image img產品圖檔 = Image.FromFile(完整圖檔路徑);
                imagelist產品圖檔.Images.Add(img產品圖檔);
                count += 1;
                //把資料讀進list裡面

                //list所有.AddRange(listProductName);
            }
            reader.Close();
            con.Close();

            Console.WriteLine($"讀取{count}筆資料");
        }

        void 顯示listview商品列表()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select id as 商品編號, pname as 商品名稱, price as 價格, pdesc as 商品說明, pcategory as 類別 from products;";
            // 改欄位名稱用 as
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            listView所有品項.Clear();
            listView所有品項.LargeImageList = null;
            listView所有品項.SmallImageList = null;
            listView所有品項.View = View.Details; //這行程式碼用來設定 listView所有品項的顯示方式為詳細資料方式，即顯示每個項目的所有欄位
            listView所有品項.Columns.Add("商品編號", 150);
            listView所有品項.Columns.Add("商品名稱", 160);
            listView所有品項.Columns.Add("價格", 100);
            listView所有品項.Columns.Add("商品說明",400);
            listView所有品項.Columns.Add("類別", 100);
            listView所有品項.GridLines = true;
            listView所有品項.FullRowSelect = true;

            for (int i = 0; i < listPid.Count; i += 1)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                listItem.Text = listPid[i].ToString();
                listItem.SubItems.Add(listProductName[i]);
                listItem.SubItems.Add(listPrice[i].ToString());
                listItem.SubItems.Add(listPdesc[i]);
                listItem.SubItems.Add(listPcategory[i]);

                listItem.Tag = listPid[i];

                listItem.BackColor = Color.NavajoWhite;
                listItem.ForeColor = Color.SaddleBrown;

                listView所有品項.Items.Add(listItem);

            }
        }

        void 計算品項總價()
        {
           

            
        }

        private void combo冰塊_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select top 200 * from products;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            所選冰塊 = list冰塊[combo冰塊.SelectedIndex];

            string strPcategory = reader["pcategory"].ToString();

            if (listView所有品項.SelectedItems.Count > 0)
            {

                if ((strPcategory.Contains("熱飲")) || (strPcategory.Contains("蛋糕"))) 
                {
                    MessageBox.Show("此品項不能加冰塊！");
                }
            }

            //SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            //con.Open();
            //string strSQL = "select * from products where pcategory='熱飲' or pcategory='蛋糕';";
            //SqlCommand cmd = new SqlCommand(strSQL, con);
            //SqlDataReader reader = cmd.ExecuteReader();

            //while (reader.Read() == true)
            //{
            //    string strPcategory = reader["pcategory"].ToString();

            //    if (strPcategory == "熱飲" || strPcategory == "蛋糕") 
            //    {
            //        MessageBox.Show("此品項無法加冰塊喔！");
            //    }
            //}

            //reader.Close();
            //con.Close();

        }

        private void combo甜度_SelectedIndexChanged(object sender, EventArgs e)
        {
            所選甜度 = list甜度[combo甜度.SelectedIndex];
        }

        private void combo加料_SelectedIndexChanged(object sender, EventArgs e)
        {
            所選單價 = list加料價格[combo加料.SelectedIndex];

            lbl單價.Text = string.Format("{0}元", 所選單價);

        }

        private void chk買購物袋_CheckedChanged(object sender, EventArgs e)
        {
            if (chk買購物袋.Checked == true)
            {
                GlobalVar.is買購物袋 = true;
            }
            else
            {
                GlobalVar.is買購物袋 = false;
            }
        }

        private void btn加入購物車_Click(object sender, EventArgs e)
        {
            ArrayList 訂購單品資訊 = new ArrayList();
            訂購單品資訊.Add(所選品項);
            訂購單品資訊.Add(所選單價);
            訂購單品資訊.Add(所選數量);
            訂購單品資訊.Add(所選品項總價);
            訂購單品資訊.Add(所選甜度);
            訂購單品資訊.Add(所選冰塊);
            訂購單品資訊.Add(所選加料);

            GlobalVar.list訂購品項資料.Add(訂購單品資訊);

            if (chk買購物袋.Checked == true)
            {
                GlobalVar.is買購物袋 = true;
            }

            MessageBox.Show("所選品項已加入購物車");
        }

        private void btn查看購物車_Click(object sender, EventArgs e)
        {
            FormOrderLists myOrderListForm = new FormOrderLists();

            myOrderListForm.ShowDialog();
        }

        private void txt數量_TextChanged(object sender, EventArgs e)
        {
            if (txt數量.Text != "")
            {
                bool is數量輸入正確 = Int32.TryParse(txt數量.Text, out 所選數量);
                if ((is數量輸入正確 == false) || (所選數量 <= 0))
                {
                    MessageBox.Show("數量輸入不正確，請至少輸入『1』");
                    所選數量 = 1;
                    txt數量.Text = 所選數量.ToString();
                }
            }
        }

        private void listView所有品項_ItemActivate(object sender, EventArgs e)
        {

        }
    }
}
