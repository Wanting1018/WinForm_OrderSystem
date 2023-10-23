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
    public partial class FormMenu : Form
    {

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        List<int> listPid = new List<int>();

        //熱飲
        List<string> listProductName = new List<string>();
        List<int> listPrice = new List<int>();
        //冷飲
        List<string> listColdProductName = new List<string>();
        List<int> listColdPrice = new List<int>();
        //甜點
        List<string> listDessertProductName = new List<string>();
        List<int> listDessertPrice = new List<int>();

        List<string> listPdesc = new List<string>();
        List<string> listPImage = new List<string>();
        List<string> listPcategory = new List<string>();

        public int SelectID = 0;

        string image_dir = @"D:\0428期中123";  //圖檔位置

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


        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
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

            if (chk買購物袋.Checked == true)
            {
                GlobalVar.is買購物袋 = true;
            }
            else
            {
                GlobalVar.is買購物袋 = false;
            }

            //表單預設值
            combo甜度.SelectedIndex = 1;
            所選甜度 = list甜度[combo甜度.SelectedIndex];

            combo冰塊.SelectedIndex = 1;
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
            GlobalVar.strDBConnectionString = scsb.ConnectionString;

            讀取商品資料庫();
            顯示商品圖片模式();
                    
        }

        void 讀取商品資料庫()
        {

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
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

        void 顯示商品圖片模式()
        {
            listView商品展示.Clear(); //要先清空
            listView商品展示.View = View.LargeIcon;   //圖片模式有四種：LargeIcon , SmallIcon , List(橫向捲軸) , Tile(圖檔大小要30*30)
            imagelist產品圖檔.ImageSize = new Size(120, 120);  //圖片大小   (256,256 最大)
            listView商品展示.LargeImageList = imagelist產品圖檔;   //LargeImageList 是LargeIcon、Tile在用   //指定到imageList 這樣才知道從哪抓資料
            listView商品展示.SmallImageList = imagelist產品圖檔;  //要使用之前 圖檔應該是小圖(ex:40*40)   SmallIcon、List在用


            for (int i = 0; i < imagelist產品圖檔.Images.Count; i++)  //索引值對應
            {
                ListViewItem item = new ListViewItem();  //ListView類似一個容器  要呈現LiseView 必須要用item  ListViewItem才能在liseview顯示資料
                item.ImageIndex = i;  // 索引值對應
                item.Text = $"{listProductName[i]} {listPrice[i]}元";  // 技巧類似listbox
                item.Font = new Font("微軟正黑體", 12, FontStyle.Bold);   // Regular一般 bold粗體 
                item.Tag = listPid[i];   // Tag藏id  因為要做使用者點擊圖片事件 所以要藏id
                listView商品展示.Items.Add(item);   //使用listView Items 才能在ListView產生
            }
        }

        void 數量輸入正確()
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

            計算所選品項總價();
        }

        void 加入購物車()
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

            MessageBox.Show("所選品項已加入購物車");
        }

        
        void 查看購物車()
        {
            FormOrderLists myOrderListForm = new FormOrderLists();

            myOrderListForm.ShowDialog();
        }

        void 計算所選品項總價()
        {

            if (listView商品展示.SelectedItems.Count >= 0)
            {
                if (GlobalVar.is買購物袋 == true)
                {
                    所選品項總價 = 所選單價 * 所選數量;
                }
                else
                {
                    所選品項總價 = 所選單價 * 所選數量;
                }
            }
            else
            {
                所選品項總價 = 0;
            }



            lbl總價.Text = string.Format("{0}元", 所選品項總價);
        }

        private void FormMenu_Activated(object sender, EventArgs e)
        {   
            // 會執行多次，當回到此表單可用的時候執行
            // Form_Activated 會執行多次 
            // Form Load 只會執行一次
            // EX：更新Form1的時候

            Console.WriteLine("Form Activiated .....");

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

        private void listView商品展示_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView商品展示.SelectedItems.Count > 0)
            {
                所選品項 = listProductName[listView商品展示.SelectedItems[0].Index];
                所選加料 = list加料品項[combo加料.SelectedIndex];
                所選單價 = listPrice[listView商品展示.SelectedItems[0].Index] + list加料價格[combo加料.SelectedIndex];

                lbl單價.Text = string.Format("{0}元", 所選單價);
                計算所選品項總價();
            }
        }

        private void combo冰塊_SelectedIndexChanged(object sender, EventArgs e)
        {
            所選冰塊 = list冰塊[combo冰塊.SelectedIndex];
        }

        private void combo甜度_SelectedIndexChanged(object sender, EventArgs e)
        {
            所選甜度 = list甜度[combo甜度.SelectedIndex];
        }

        private void combo加料_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        

        private void txt數量_TextChanged(object sender, EventArgs e)
        {
            數量輸入正確();
        }

        private void btn加入購物車_Click(object sender, EventArgs e)
        {
            加入購物車();
        }

        private void btn查看購物車_Click(object sender, EventArgs e)
        {
            查看購物車();
        }

        private void listView商品展示_ItemActivate(object sender, EventArgs e)
        {
            if (listView商品展示.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView商品展示.SelectedItems[0];
                int selectedIndex = selectedItem.Index;

                if (selectedIndex < 7)
                {
                    combo冰塊.Visible = false;
                    combo冰塊.SelectedIndex = 0;
                    combo加料.Visible = false;
                    combo加料.SelectedIndex = 0;
                    lbl冰塊.Visible = false;
                    lbl加料.Visible = false;

                }
                else if ((selectedIndex >= 7) && (selectedIndex <= 15))
                {
                    combo冰塊.Visible = true;
                    combo加料.Visible = true;
                    combo甜度.Visible = true;
                    lbl冰塊.Visible = true;
                    lbl加料.Visible = true;
                    lbl甜度.Visible = true;
                }
                else if (selectedIndex > 15)
                {
                    combo冰塊.Visible = false;
                    combo冰塊.SelectedIndex = 0;
                    combo加料.Visible = false;
                    combo加料.SelectedIndex = 0;
                    combo甜度.Visible = false;
                    combo甜度.SelectedIndex = 0;
                    lbl冰塊.Visible = false;
                    lbl加料.Visible = false;
                    lbl甜度.Visible = false;
                }
                else
                {
                    combo冰塊.Visible = true;
                    combo加料.Visible = true;
                    combo甜度.Visible = true;
                    lbl冰塊.Visible = true;
                    lbl加料.Visible = true;
                    lbl甜度.Visible = true;
                }

            }

            所選品項 = listProductName[listView商品展示.SelectedItems[0].Index];
            所選加料 = list加料品項[combo加料.SelectedIndex];
            所選單價 = listPrice[listView商品展示.SelectedItems[0].Index] + list加料價格[combo加料.SelectedIndex];

            lbl單價.Text = string.Format("{0}元", 所選單價);
            計算所選品項總價();
        }
    }
}
