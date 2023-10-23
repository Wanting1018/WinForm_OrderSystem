using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0428期中
{
    public partial class Product_Details : Form   //參考WindowsFormApp4
    {

        public int selectID = 0;     // 要辨別是商品新增或者修改模式 當開啟修改模式時，會把商品ID傳過來。 當開啟商品新增模式時，不會回傳ID  所以用ID有沒有傳回來判斷 
        string image_modify_name = "";   //圖檔修改名稱
        bool is修改圖檔 = false;   // 修改之後改成true 儲存資料庫圖檔



        public Product_Details()
        {
            InitializeComponent();
        }

        private void Product_Details_Load(object sender, EventArgs e)
        {
            //if (GlobalVar.int權限 >= 10000)   //會員
            //{

            //    groupBox商品修改.Visible = false;
            //    groupBox商品新增.Visible = false;
            //    txt商品名稱.ReadOnly = true;   //ReadOnly只能讀取無法修改
            //    txt價格.ReadOnly = true;
            //    txt商品描述.ReadOnly = true;

            //}
            //else if ((GlobalVar.int權限 >= 1000) && (GlobalVar.int權限 <= 4999))
            //{   //員工

            //    if (selectID == 0)
            //    {//新增模式
            //        groupBox商品修改.Visible = false;  //隱藏
            //        groupBox商品新增.Visible = true;
            //    }
            //    else
            //    {//修改模式
            //        groupBox商品修改.Visible = true;
            //        groupBox商品新增.Visible = false;  //隱藏
            //    }
            //}

            lblid.Text = selectID.ToString();
            顯示商品詳細資訊();
        }

        void 顯示商品詳細資訊()
        {
            if (selectID > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from products where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblid.Text = reader["id"].ToString();
                    txt商品名稱.Text = reader["pname"].ToString();
                    txt價格.Text = reader["price"].ToString();
                    txt商品描述.Text = reader["pdesc"].ToString();
                    image_modify_name = reader["pimage"].ToString();
                    txt商品分類.Text = reader["pcategory"].ToString();
                    
                    
                    string 圖檔完整路徑 = $"{GlobalVar.image_dir}\\{image_modify_name}";
                    pictureBox商品圖檔.Image = Image.FromFile(圖檔完整路徑);
                }

                reader.Close();
                con.Close();
            }
        }

        private void btn修改選取商品圖片_Click(object sender, EventArgs e)
        {
            選取商品圖片();
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt價格.Text != "") && (txt商品分類.Text != "") && (txt商品描述.Text != "") && (pictureBox商品圖檔.Image != null)) 
            {
                if (is修改圖檔 == true)
                {
                    pictureBox商品圖檔.Image.Save(GlobalVar.image_dir + @"\" + image_modify_name);   //picturebox有儲存圖檔的功能(Save)
                    is修改圖檔 = false;   //儲存完之後就把修改圖檔的bool改成false
                }

                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "update products set pname=@NewName,price=@NewPrice,pcategory=@NewCategory,pdesc=@NewDesc,pimage=@NewImage where id=@SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewDesc", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewImage", image_modify_name);
                cmd.Parameters.AddWithValue("@NewCategory", txt商品分類.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料異動成功，影響{rows}筆資料");

            }
            else
            {
                MessageBox.Show("欲修改，所有欄位必填！");
            }
        }

        void 清空欄位()
        {
            lblid.Text = "";
            txt商品名稱.Clear();
            txt價格.Clear();
            txt商品分類.Clear();
            txt商品描述.Clear();
            pictureBox商品圖檔.Image = null;
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        void 選取商品圖片()
        {

            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "檔案類型 (*.jpg, *.jpeg , *.png) | *.jpeg; *.jpg; *.png";

            DialogResult R = f.ShowDialog();
            btn修改選取商品圖片.Enabled = false;

            if (R == DialogResult.OK) 
            {
                pictureBox商品圖檔.Image = Image.FromFile(f.FileName);
                string 檔案副檔名 = System.IO.Path.GetExtension(f.SafeFileName);

                Random myRnd = new Random();
                image_modify_name = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + 檔案副檔名;
                is修改圖檔 = true;

                Console.WriteLine(image_modify_name);

            }
        }

        private void btn選取商品圖片_Click(object sender, EventArgs e)
        {
            選取商品圖片();
        }

        private void btn儲存新增商品_Click(object sender, EventArgs e)
        {

            if ((txt商品名稱.Text != "") && (txt價格.Text != "") && (txt商品分類.Text != "") && (txt商品描述.Text != "") && (pictureBox商品圖檔.Image != null))
            {
                if (is修改圖檔 == true)
                {
                    pictureBox商品圖檔.Image.Save(GlobalVar.image_dir + @"\" + image_modify_name);   //picturebox有儲存圖檔的功能(Save)
                    is修改圖檔 = false;   //儲存完之後就把修改圖檔的bool改成false
                }

                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "insert into products values ( @NewName, @NewPrice, @NewDesc, @NewImage,@NewCategory);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue( "@NewName", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt價格.Text, out intPrice);
                cmd.Parameters.AddWithValue( "@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewDesc", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewImage", image_modify_name);
                cmd.Parameters.AddWithValue("@NewCategory", txt商品分類.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料異動成功，影響{rows}筆資料");

            }
            else
            {
                MessageBox.Show("所有欄位必填才能新增商品！");
            }
        }
    }
}
