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
using System.Collections.Specialized;

namespace _0428期中
{
    public partial class FormOrderDetails : Form
    {

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();   //SQL連線字串產生器  資料庫連線字串(連線資料庫的相關參數)
        string strDBConnectionString = "";
        List<int> searchIDs = new List<int>();


        public FormOrderDetails()
        {
            InitializeComponent();
        }

        private void FormOrderDetails_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";   // DataSource伺服器名稱    . 代表本機伺服器名稱
            scsb.InitialCatalog = "my_db";  // InitialCatalog 資料庫名稱
            scsb.IntegratedSecurity = true;  // IntegratedSecurity ：Windows 驗證方式

            //即可取得資料庫連線字串
            strDBConnectionString = scsb.ConnectionString;

            combo訂單資料欄位.Items.Add("ID");
            combo訂單資料欄位.Items.Add("Customer");
            combo訂單資料欄位.SelectedIndex = 0;

            產生訂單資料列表DGV();
        }

        void 產生訂單資料列表DGV()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select ID as '訂單編號' , Customer as '顧客姓名', OrderDetail as '訂單明細', TotalPrice as '訂單總價', OrderTime as '訂單成立時間' from OrderDetails;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv訂單資料列表.DataSource = dt;
            }

            reader.Close();
            con.Close();

        }

        void 清空欄位()
        {
            lblid.Text = "";
            txt姓名.Clear();
            txt訂單內容.Clear();
            txt訂單總價.Clear();
            txt欄位關鍵字搜尋.Clear();
            dtp訂單成立日期.Value = DateTime.Now;
        }

        private void btn訂單資料修改_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblid.Text, out intID);

            if ((intID > 0) && (txt姓名.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();

                string strSQL = "update OrderDetails set Customer=@NewName,OrderDetail=@NewOrderDetail,TotalPrice=@NewTotalPrice,OrderTime=@NewOrderTime where id=@SearchID;";

                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewOrderDetail", txt訂單內容.Text);
                cmd.Parameters.AddWithValue("@NewTotalPrice", txt訂單總價.Text);
                cmd.Parameters.AddWithValue("@NewOrderTime", dtp訂單成立日期.Value);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"訂單資料修改成功,{rows}筆資料受影響");

            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btn會員基本資料_Click(object sender, EventArgs e)
        {
            this.Hide();

            Persons FormPersons = new Persons();
            FormPersons.ShowDialog();

            this.Show();
        }

        private void btn刪除訂單資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblid.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "delete from OrderDetails where ID = @DeleteID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                清空欄位();
                MessageBox.Show($"訂單資料已刪除，{rows}筆資料受影響");
            }
        }

        private void btn重新整理_Click(object sender, EventArgs e)
        {
            清空欄位();
            產生訂單資料列表DGV();
        }

        private void btn搜尋關鍵字_Click(object sender, EventArgs e)
        {
            if (txt欄位關鍵字搜尋.Text != "")
            {
                listbox搜尋結果.Items.Clear();
                searchIDs.Clear();
                string str欄位名稱 = combo訂單資料欄位.SelectedItem.ToString();

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = $"select * from OrderDetails where OrderTime >= @OrderDateStart and OrderTime <= @OrderDateEnd and {str欄位名稱} like @SearchKeyWord;";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@OrderDateStart",dtp開始時間.Value);
                cmd.Parameters.AddWithValue("@OrderDateEnd", dtp結束時間.Value);
                cmd.Parameters.AddWithValue("@SearchKeyWord", $"%{txt欄位關鍵字搜尋.Text}%");

                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                if (reader.Read() == true)
                {
                    lblid.Text = reader["ID"].ToString();
                    txt姓名.Text = reader["Customer"].ToString();
                    txt訂單內容.Text = reader["OrderDetail"].ToString();
                    txt訂單總價.Text = reader["TotalPrice"].ToString();                   
                    dtp訂單成立日期.Value = Convert.ToDateTime(reader["OrderTime"]);

                }
                else
                {
                    MessageBox.Show("查無此訂單");
                }

                while (reader.Read() == true)
                {
                    searchIDs.Add((int)reader["ID"]);  //轉int    convert強制轉換 ()物件轉成原本資料型態也可以做自動轉換(整數轉浮點、布林)  (整數轉字串不支援)

                    listbox搜尋結果.Items.Add($"{reader["ID"]} {reader["Customer"]}  {reader["TotalPrice"]} {reader["OrderTime"]}");
                    count += 1;
                }
                if (count == 0)
                {
                    MessageBox.Show("查無此訂單資料");
                }

                reader.Close();
                con.Close();
            }
        }

        private void listbox搜尋結果_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox搜尋結果.SelectedIndex >= 0)
            {
                int selectID = searchIDs[listbox搜尋結果.SelectedIndex];  //索引值對應

                //複製btn資料搜尋 再修改
                // 複製上面的資料筆數
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from OrderDetails where ID = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);  //第一個參數名稱要用字串的形式  //第二個參數值可以用字串帶入法
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblid.Text = reader["ID"].ToString();
                    txt姓名.Text = reader["Customer"].ToString();
                    txt訂單內容.Text = reader["OrderDetail"].ToString();
                    txt訂單總價.Text = reader["TotalPrice"].ToString();
                    dtp訂單成立日期.Value = Convert.ToDateTime(reader["OrderTime"]);

                }
                else
                {
                    MessageBox.Show("訂單管理中查無此訂單，請重新輸入");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
        }

        private void dgv訂單資料列表_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // rowindex為資料筆的索引值  (列)
            {
                string strSelectID = dgv訂單資料列表.Rows[e.RowIndex].Cells[0].Value.ToString();  //取得那一列的物件  cell[0]要取得那一列物件的第一個儲存格(Cell)  為了防止錯誤先將值轉成字串(比較保險)
                // 直接value轉整數有風險 萬一value今天是null或者字串 所以要用上面的方法
                int selectID = 0;
                Int32.TryParse(strSelectID, out selectID);  //再將上面轉成的字串 轉回整數

                //直接複製上面listbox的
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from OrderDetails where ID = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);  //第一個參數名稱要用字串的形式  //第二個參數值可以用字串帶入法
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblid.Text = reader["ID"].ToString();
                    txt姓名.Text = reader["Customer"].ToString();
                    txt訂單內容.Text = reader["OrderDetail"].ToString();
                    txt訂單總價.Text = reader["TotalPrice"].ToString();
                    dtp訂單成立日期.Value = Convert.ToDateTime(reader["OrderTime"]);

                }
                else
                {
                    MessageBox.Show("訂單管理中查無此訂單");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
        }

    }
}
