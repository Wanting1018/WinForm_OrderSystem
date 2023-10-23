using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;   //別忘了加入 才有辦法使用

namespace _0428期中
{
    public partial class Persons : Form    //參考WindowsFormApp3
    {

        //建立會員變數
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();   //SQL連線字串產生器  資料庫連線字串(連線資料庫的相關參數)
        string strDBConnectionString = "";
        List<int> searchIDs = new List<int>();  //進階搜尋結果存ID
        int int搜尋婚姻狀態 = 0;   // 0：全部   1：已婚   2：單身



        public Persons()
        {
            InitializeComponent();
        }

        private void Persons_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";   // DataSource伺服器名稱    . 代表本機伺服器名稱
            scsb.InitialCatalog = "my_db";  // InitialCatalog 資料庫名稱
            scsb.IntegratedSecurity = true;  // IntegratedSecurity ：Windows 驗證方式

            //即可取得資料庫連線字串
            strDBConnectionString = scsb.ConnectionString;

            combo資料欄位.Items.Add("姓名");
            combo資料欄位.Items.Add("電話");
            combo資料欄位.Items.Add("地址");
            combo資料欄位.Items.Add("email");
            combo資料欄位.SelectedIndex = 0;

            radio全部.Checked = true;  //預設
            int搜尋婚姻狀態 = 0;   //預設

            產生會員資料列表DGV();        
        }

        void 清空欄位()
        {
            lblid.Text = "";
            txt姓名.Clear();
            txt電話.Clear();
            txt地址.Clear();
            txtemail.Clear();
            txt點數.Clear();
            dtp生日.Value = DateTime.Now;
            chk婚姻狀態.Checked = false;

        }

        private void btn資料筆數_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);   // con由資料庫連線字串產生
            con.Open();
            string strSQL = "select top 100 * from persons";
            SqlCommand cmd = new SqlCommand(strSQL, con);   // 每一個資料庫物件都是基於前一個物件，必須像SOP一樣 一個一個產生  SqlCommand：執行SQL命令
            //第一個參數strSQL：SQL語法  ， 第二個參數con：SQL連線物件
            SqlDataReader reader = cmd.ExecuteReader();  // ExecuteReader 這個方法會產生SqlDataReader資料讀取器 →  SqlDataReader：SQL資料讀取器(取得SQL資料)

            string strMsg = "";
            int count = 0;

            while (reader.Read() == true)
            {
                int id = Convert.ToInt32(reader["id"]);
                string 姓名 = reader["姓名"].ToString();
                string 電話 = reader["電話"].ToString();
                string 地址 = reader["地址"].ToString();
                string email = reader["email"].ToString();
                DateTime 生日 = Convert.ToDateTime(reader["生日"]);
                bool 婚姻狀態 = Convert.ToBoolean(reader["婚姻狀態"]);
                int 點數 = Convert.ToInt32(reader["點數"]);

                strMsg += $"{id}： {姓名}   {電話}   {email}   {地址}   {生日}   {婚姻狀態}   {點數} \n";
                count += 1;

            }

            strMsg += $"資料筆數：{count}";
            reader.Close();    //一定要先關reader再關con 因為reader是基於con來產生   con提供reader物件參考
            con.Close();    //如果先關con程式會錯誤
            MessageBox.Show(strMsg);


        }

        private void btn資料搜尋_Click(object sender, EventArgs e)
        {
            if (txt姓名.Text != "") 
            {
                // 複製上面的資料筆數
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from persons where 姓名 like @SearchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", $"%{txt姓名.Text}%");  //第一個參數名稱要用字串的形式  //第二個參數值可以用字串帶入法
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblid.Text = reader["id"].ToString();
                    txt姓名.Text = reader["姓名"].ToString();
                    txt電話.Text = reader["電話"].ToString();
                    txt地址.Text = reader["地址"].ToString();
                    txtemail.Text = reader["email"].ToString();
                    txt點數.Text = reader["點數"].ToString();
                    dtp生日.Value = Convert.ToDateTime(reader["生日"]);
                    chk婚姻狀態.Checked = Convert.ToBoolean(reader["婚姻狀態"]);

                }
                else
                {
                    MessageBox.Show("會員資料中查無此人，請重新輸入");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請在姓名欄位輸入任意字元關鍵字來做搜尋");
            }
        }


        private void btn資料修改_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblid.Text, out intID);

            if ((intID >= 0) && (txt姓名.Text != "") && (txt電話.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();

                string strSQL = "update persons set 姓名=@NewName,電話=@NewPhone,地址=@NewAddress,email=@NewEmail,生日=@NewBirthday,婚姻狀態=@NewMarriage,點數=@NewPoint where id=@SearchID;";

                SqlCommand cmd = new SqlCommand(strSQL, con);

                //複製下面新增資料的，要修改甚麼資料就把程式碼中@XXX 複製到上面對應的欄位
                cmd.Parameters.AddWithValue("@SearchID", intID);  // 下面新增沒有的 所以要增加
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtemail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewMarriage", chk婚姻狀態.Checked);
                /*
                 @NewName 是一個 SQL 參數，用於在 SQL 語句中代表一個要比對的欄位或值。在這個程式碼片段中，@NewName 是一個命名參數，它將會在 SQL 語句中代表要比對的姓名。
                當 SqlCommand 物件執行 SQL 語句時，@NewName 的值會由 cmd.Parameters.AddWithValue("@NewName", txt姓名.Text) 方法所指定的值取代，這裡的 txt姓名.Text 代表使用者在輸入框中輸入的姓名。
                 */

                int intpoints = 0;
                Int32.TryParse(txt點數.Text, out intpoints);
                cmd.Parameters.AddWithValue("@NewPoint", intpoints);

                int rows = cmd.ExecuteNonQuery();  // ExecuteNonQuery ：執行不查詢
                con.Close();
                MessageBox.Show($"會員資料修改成功,{rows}筆資料受影響");

            }
        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt電話.Text != ""))
            {        
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();

                //將重複的資料 拒絕新增 ↓
                string strSQL_repeat = "select count(*) from persons where  電話=@NewPhone or email=@NewEmail";
                SqlCommand cmd2 = new SqlCommand(strSQL_repeat, con);

                cmd2.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd2.Parameters.AddWithValue("@NewEmail", txtemail.Text);
                int count = (int)cmd2.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("電話或email已經存在，請檢查後修改資料或重新輸入");
                    return;
                }
                //將重複的資料 拒絕新增 ↑

                string strSQL_insert = "insert into persons values(@Newname,@NewPhone,@NewAddress,@NewEmail,@NewBirthday,@NewMarriage,@NewPoint)";
                SqlCommand cmd = new SqlCommand(strSQL_insert, con);

                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtemail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewMarriage", chk婚姻狀態.Checked);

                int intpoints = 0;
                Int32.TryParse(txt點數.Text, out intpoints);
                cmd.Parameters.AddWithValue("@NewPoint", intpoints);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"會員資料新增成功，{rows}筆資料受影響");
            }
            else
            {
                MessageBox.Show("姓名電話必填");
            }
        }

        private void btn刪除資料_Click(object sender, EventArgs e)
        {    // 先用姓名或電話搜尋 再按刪除，再確認是否有確實刪除
            int intID = 0;
            Int32.TryParse(lblid.Text, out intID);

            if (intID > 0)   //如果沒有轉換成功為0
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "delete from persons where id=@DeleteID";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                清空欄位();
                MessageBox.Show($"資料已刪除，{rows}筆資料受影響");

            }
            else
            {
                MessageBox.Show("請先使用資料搜尋在姓名欄位輸入任意字元，再進行刪除");
            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btn搜尋關鍵字_Click(object sender, EventArgs e)
        {
            if (txt欄位關鍵字搜尋.Text != "")
            {
                listbox搜尋結果.Items.Clear();  //清除搜尋結果
                searchIDs.Clear();   //最一開始定義時，SearchID是存取進階搜尋結果
                string str欄位名稱 = combo資料欄位.SelectedItem.ToString();    //使用者選擇甚麼欄位
                string sql婚姻狀態查詢語法 = "";  

              
                if (int搜尋婚姻狀態 == 0)
                { //全部
                    sql婚姻狀態查詢語法 = "";
                }
                else if (int搜尋婚姻狀態 == 1)
                {//已婚
                    sql婚姻狀態查詢語法 = "and 婚姻狀態 = 1";  //此婚姻狀態 = 1 是true
                }
                else if (int搜尋婚姻狀態 == 2)
                {//單身
                    sql婚姻狀態查詢語法 = "and 婚姻狀態 = 0";  // 此婚姻狀態 = 0 是false
                }

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = $"select*from persons where 生日>= @BirthdayStart and 生日<= @BirthdayEnd and {str欄位名稱} like @SearchKeyWord {sql婚姻狀態查詢語法};";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@BirthdayStart", dtp開始時間.Value);
                cmd.Parameters.AddWithValue("@BirthdayEnd", dtp結束時間.Value);  // SQL的時間日期的相關格式跟C#的都相容
                cmd.Parameters.AddWithValue("@SearchKeyWord", $"%{txt欄位關鍵字搜尋.Text}%");
                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read() == true)
                {
                    searchIDs.Add((int)reader["id"]);    //轉int    convert強制轉換 ()物件轉成原本資料型態也可以做自動轉換(整數轉浮點、布林)  (整數轉字串不支援)
                    listbox搜尋結果.Items.Add($"{reader["id"]} {reader["姓名"]} {reader["電話"]}");
                    count += 1;
                }

                if (count == 0)
                {
                    MessageBox.Show("查無此人");
                }
                reader.Close();
                con.Close();  //關閉連線

            }
        }

        private void radio全部_CheckedChanged(object sender, EventArgs e)
        {
            int搜尋婚姻狀態 = 0;
        }

        private void radio已婚_CheckedChanged(object sender, EventArgs e)
        {
            int搜尋婚姻狀態 = 1;
        }

        private void radio單身_CheckedChanged(object sender, EventArgs e)
        {
            int搜尋婚姻狀態 = 2;
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
                string strSQL = "select * from persons where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);  //第一個參數名稱要用字串的形式  //第二個參數值可以用字串帶入法
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblid.Text = reader["id"].ToString();
                    txt姓名.Text = reader["姓名"].ToString();
                    txt電話.Text = reader["電話"].ToString();
                    txt地址.Text = reader["地址"].ToString();
                    txtemail.Text = reader["email"].ToString();
                    txt點數.Text = reader["點數"].ToString();
                    dtp生日.Value = Convert.ToDateTime(reader["生日"]);
                    chk婚姻狀態.Checked = Convert.ToBoolean(reader["婚姻狀態"]);

                }
                else
                {
                    MessageBox.Show("會員資料中查無此人，請重新輸入");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
        }

        void 產生會員資料列表DGV()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from persons";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv會員資料列表.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void dgv會員資料列表_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // rowindex為資料筆的索引值  (列)
            {
                string strSelectID = dgv會員資料列表.Rows[e.RowIndex].Cells[0].Value.ToString();  //取得那一列的物件  cell[0]要取得那一列物件的第一個儲存格(Cell)  為了防止錯誤先將值轉成字串(比較保險)
                // 直接value轉整數有風險 萬一value今天是null或者字串 所以要用上面的方法
                int selectID = 0;
                Int32.TryParse(strSelectID, out selectID);  //再將上面轉成的字串 轉回整數

                //直接複製上面listbox的
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from persons where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);  //第一個參數名稱要用字串的形式  //第二個參數值可以用字串帶入法
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblid.Text = reader["id"].ToString();
                    txt姓名.Text = reader["姓名"].ToString();
                    txt電話.Text = reader["電話"].ToString();
                    txt地址.Text = reader["地址"].ToString();
                    txtemail.Text = reader["email"].ToString();
                    txt點數.Text = reader["點數"].ToString();
                    dtp生日.Value = Convert.ToDateTime(reader["生日"]);
                    chk婚姻狀態.Checked = Convert.ToBoolean(reader["婚姻狀態"]);

                }
                else
                {
                    MessageBox.Show("會員資料中查無此人");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
        }
    }
}
