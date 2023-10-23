using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace _0428期中
{
    public partial class Products : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();   //SQL連線字串產生器
        List<string> listProductName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listPid = new List<int>();
        List<string> listPcategory = new List<string>();
        List<string> listPdesc = new List<string>();

        string image_dir = @"D:\0428期中123";



        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "my_db";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;

            讀取商品資料庫();
            顯示listView_圖片模式();
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
                listPcategory.Add((string)reader["pcategory"]);

                string 完整圖檔路徑 = $"{GlobalVar.image_dir}\\{image_name}";
                Image img產品圖檔 = Image.FromFile(完整圖檔路徑);
                imageList產品圖檔.Images.Add(img產品圖檔);
                count += 1;
            }
            reader.Close();
            con.Close();

            Console.WriteLine($"讀取{count}筆資料");
        }

        void 顯示listView_圖片模式()
        {
            listView商品展示.Clear();
            listView商品展示.View = View.LargeIcon;
            imageList產品圖檔.ImageSize = new Size(110, 110);
            listView商品展示.LargeImageList = imageList產品圖檔;
            listView商品展示.SmallImageList = imageList產品圖檔;
            

            for (int i = 0; i < imageList產品圖檔.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();  //ListView類似一個容器  要呈現LiseView 必須要用item  ListViewItem才能在liseview顯示資料
                item.ImageIndex = i;  // 索引值對應
                item.Text = $"{listProductName[i]} {listPrice[i]}元";  // 技巧類似listbox
                item.Font = new Font("微軟正黑體", 10, FontStyle.Regular);   // Regular一般 bold粗體 
                item.Tag = listPid[i];   // Tag藏id  因為要做使用者點擊圖片事件 所以要藏id
                listView商品展示.Items.Add(item);   //使用listView Items 才能在ListView產生
            }

        }


        private void btn圖片模式_Click(object sender, EventArgs e)
        {
            顯示listView_圖片模式();
        }

        void 顯示listView_列表模式()
        {
            listView商品展示.Clear();
            listView商品展示.LargeImageList = null;
            listView商品展示.SmallImageList = null;
            listView商品展示.View = View.Details;
            listView商品展示.Columns.Add("id", 100);
            listView商品展示.Columns.Add("pname", 200);
            listView商品展示.Columns.Add("price", 100);
            listView商品展示.Columns.Add("pcategory", 100);
            listView商品展示.GridLines = true;
            listView商品展示.FullRowSelect = true;

            for (int i = 0; i < listPid.Count; i += 1)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                listItem.Text = listPid[i].ToString();
                listItem.SubItems.Add(listProductName[i]);
                listItem.SubItems.Add(listPrice[i].ToString());
                listItem.SubItems.Add(listPcategory[i]);
                listItem.Tag = listPid[i];
                listItem.ForeColor = Color.Brown;
                listView商品展示.Items.Add(listItem);
            }
        }

        private void btn列表模式_Click(object sender, EventArgs e)
        {
            顯示listView_列表模式();
        }

        private void btn新增商品_Click(object sender, EventArgs e)
        {
            Product_Details product_Details_form = new Product_Details();
            product_Details_form.ShowDialog();

            
        }

        void 重新載入資料()
        {
            listPid.Clear();
            listProductName.Clear();
            listPrice.Clear();
            imageList產品圖檔.Images.Clear();
            讀取商品資料庫();

            if (listView商品展示.View == View.Details)
            {
                顯示listView_列表模式();
            }
            else
            {
                顯示listView_圖片模式();
            }
        }

        private void btn重新整理_Click(object sender, EventArgs e)
        {
            重新載入資料();
        }

        private void listView商品展示_ItemActivate(object sender, EventArgs e)
        {
            Product_Details product_Details_form = new Product_Details();  //從新增商品那邊複製過來
            product_Details_form.selectID = (int)listView商品展示.SelectedItems[0].Tag;

            product_Details_form.ShowDialog();

        }
    }
}
