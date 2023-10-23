using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using System.Data.SqlClient;

namespace _0428期中
{


    public partial class Form1 : Form
    {

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();   //SQL連線字串產生器
        List<string> listProductName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listPid = new List<int>();
        List<string> listPcategory = new List<string>();
        List<string> listPdesc = new List<string>();


        //List<string> list熱飲品項 = new List<string>();
        //List<string> list冷飲品項 = new List<string>();
        //List<string> list蛋糕品項 = new List<string>();

        //List<int> list熱飲價格 = new List<int>();
        //List<int> list冷飲價格 = new List<int>();
        //List<int> list蛋糕價格 = new List<int>();

        List<string> list內用桌號 = new List<string>();
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
        string 所選桌號 = "";

        bool is外帶 = false;
        bool is買購物袋 = false;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            


            //內用桌號
            list內用桌號.Add("");
            list內用桌號.Add("第⓵桌");
            list內用桌號.Add("第⓶桌");
            list內用桌號.Add("第⓷桌");
            list內用桌號.Add("第⓸桌");
            list內用桌號.Add("第⓹桌");
            list內用桌號.Add("第⓺桌");

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



            //加料價格及品項
            for (int i = 0; i < list加料品項.Count; i += 1)
            {
                string strItemA = $"{list加料品項[i]}    {list加料價格[i]}元";
                combo加料.Items.Add(strItemA);
            }

            foreach (string item in list冰塊)
            {
                combo冰塊.Items.Add(item);
            }

            foreach (string item in list甜度)
            {
                combo甜度.Items.Add(item);
            }

            foreach(string item in list內用桌號)
            {
                combo內用桌號.Items.Add(item);
            }

            //表單預設值

            combo冰塊.SelectedIndex = 0;  //SelectedIndex所選所引值
            所選冰塊 = list冰塊[combo冰塊.SelectedIndex];

            combo甜度.SelectedIndex = 0;
            所選甜度 = list甜度[combo甜度.SelectedIndex];

            combo加料.SelectedIndex = 0;
            所選加料 = list加料品項[combo加料.SelectedIndex];

            combo內用桌號.SelectedIndex = 0;
            所選桌號 = list內用桌號[combo內用桌號.SelectedIndex];

            txt數量.Text = 1.ToString();
            所選數量 = 1;

            radio外帶.Checked = true;
            is外帶 = true;

            chk買購物袋.Checked = false;
            is買購物袋 = false;

            顯示listVIew_飲品列表模式();

        }

        void 計算所選品項總價()
        {

            //if (listBox所有品項.SelectedIndex >= 0)   //代表使用者有選到品項
            //{
            //    所選品項總價 = 所選單價 * 所選數量;
            //}
            //else if (listBox蛋糕品項.SelectedIndex >= 0)
            //{
            //    所選品項總價 = 所選單價 * 所選數量;
            //}
            //else  // 如果都沒有選到品項，則將總價歸零
            //{
            //    所選品項總價 = 0;
            //}

            //lbl總價.Text = String.Format("{0}元", 所選品項總價);
            ////將【所選品項總價】的值格式化為字串，並加上『元』的字眼，最後將這個字串指定給名為 lbl總價      
        }


        private void listBox飲品品項_SelectedIndexChanged(object sender, EventArgs e)
        {   //※※還要再確認

            //listBox蛋糕品項.SelectedIndex = -1;
            //int select飲品 = listBox所有品項.SelectedIndex;
           
            //if ((select飲品 >= 0) && (select飲品 < listBox所有品項.Items.Count)) 
            //{
            //    if ((select飲品 == 0) || (select飲品 == GlobalVar.list熱飲品項.Count))   //select飲品==0 (熱飲標題)   select飲品==list熱飲品項.count(8) (listbox的[8]索引值->冷飲標題)
            //    {
            //        MessageBox.Show("這個不能喝！請重新選擇");   //無法加到購物車的情況
            //    }

            //    else if (((select飲品 > 0) && (select飲品 < GlobalVar.list熱飲品項.Count)) && (combo冰塊.SelectedIndex > 0))
            //    {
            //        MessageBox.Show("熱飲沒辦法再加冰塊喔！");   //無法加到購物車的情況
            //        combo冰塊.SelectedIndex = 0;
            //    }

            //    else if (((select飲品 > 0) && (select飲品 < GlobalVar.list熱飲品項.Count)) && (combo加料.SelectedIndex > 0))
            //    {
            //        MessageBox.Show("熱飲不能另外加料喔！");   //無法加到購物車的情況
            //        combo加料.SelectedIndex = 0;
            //    }

            //    else if ((select飲品 > 0) && (select飲品 < GlobalVar.list熱飲品項.Count))    //熱飲索引值在listbox中 1~7  0為熱飲標題
            //    {//選到熱飲 可加到購物車
            //        所選品項 = GlobalVar.list熱飲品項[select飲品];
            //        所選單價 = GlobalVar.list熱飲價格[select飲品];
            //    }

            //    else if ((select飲品 > GlobalVar.list熱飲品項.Count) && (select飲品 < listBox所有品項.Items.Count))    //冷飲索引值在listbox中 9~18  8為冷飲標題
            //    {//選到冷飲 可加到購物車
            //        所選品項 = GlobalVar.list冷飲品項[select飲品 - GlobalVar.list熱飲品項.Count];
            //        所選單價 = GlobalVar.list冷飲價格[select飲品 - GlobalVar.list熱飲品項.Count] + list加料價格[combo加料.SelectedIndex];
            //    }

            //}

            //lbl單價.Text = string.Format("{0}元", 所選單價);
            //計算所選品項總價();
        }

        private void listBox蛋糕品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox所有品項.SelectedIndex = -1;
            //int select蛋糕 = listBox蛋糕品項.SelectedIndex;
           
            //if(select蛋糕>=0)
            //{
            //    if (select蛋糕 == 0)
            //    {
            //        MessageBox.Show("這個不能吃！請重新選擇");
            //    }
            //    else if ((select蛋糕 > 0) && (combo冰塊.SelectedIndex > 0))
            //    {
            //        MessageBox.Show("蛋糕不能加冰塊唷！");
            //        combo冰塊.SelectedIndex = 0;
            //    }
            //    else if ((select蛋糕 > 0) && (combo甜度.SelectedIndex > 0))
            //    {
            //        MessageBox.Show("蛋糕不能調甜度喔！");
            //        combo甜度.SelectedIndex = 0;
            //    }
            //    else if ((select蛋糕 > 0) && (combo加料.SelectedIndex > 0))
            //    {
            //        MessageBox.Show("蛋糕不能另外加料啦！");
            //        combo加料.SelectedIndex = 0;
            //    }
            //    else if ((select蛋糕 > 0) && (listBox所有品項.SelectedIndex > 0))
            //    {
            //        MessageBox.Show("別那麼貪心！購物車一次只能加入一種品項");
            //        listBox所有品項.SelectedIndex = -1;
            //        listBox蛋糕品項.SelectedIndex = -1;
            //        lbl單價.Text="";
            //    }

            //    所選品項 = GlobalVar.list蛋糕品項[select蛋糕];
            //    所選單價 = GlobalVar.list蛋糕價格[select蛋糕];

            //    lbl單價.Text = string.Format("{0}元", 所選單價);
            //    計算所選品項總價();
            //}
        }

        private void txt訂購人_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radio內用_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.is外帶 = false;
            MessageBox.Show("請選擇桌號");
        }

        private void radio外帶_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.is外帶 = true;
            combo內用桌號.SelectedIndex = 0;
        }
        private void combo內用桌號_SelectedIndexChanged(object sender, EventArgs e)
        {
            所選桌號 = list內用桌號[combo內用桌號.SelectedIndex];
        }

        private void combo冰塊_SelectedIndexChanged(object sender, EventArgs e)
        {
            //所選冰塊 = list冰塊[combo冰塊.SelectedIndex];

            //int select飲品 = listBox所有品項.SelectedIndex;
            
            //if(((select飲品 > 0) && (select飲品 < GlobalVar.list熱飲品項.Count)) && (combo冰塊.SelectedIndex > 0))
            //{
            //    MessageBox.Show("熱飲沒辦法再加冰塊喔！");   //無法加到購物車的情況
            //    combo冰塊.SelectedIndex = 0;
            //}

        }

        private void combo甜度_SelectedIndexChanged(object sender, EventArgs e)
        {
            所選甜度 = list甜度[combo甜度.SelectedIndex];
        }

        private void combo加料_SelectedIndexChanged(object sender, EventArgs e)
        {

            //int select飲品 = listBox所有品項.SelectedIndex;


            //if ((select飲品 >= 0) && (select飲品 < listBox所有品項.Items.Count))
            //{
            //    if ((select飲品 == 0) || (select飲品 == GlobalVar.list熱飲品項.Count))   //select飲品==0 (熱飲標題)   select飲品==list熱飲品項.count(8) (listbox的[8]索引值->冷飲標題)
            //    {
            //        MessageBox.Show("這個不能喝！請重新選擇");   //無法加到購物車的情況
            //    }

            //    else if (((select飲品 > 0) && (select飲品 < GlobalVar.list熱飲品項.Count)) && (combo冰塊.SelectedIndex > 0))
            //    {
            //        MessageBox.Show("熱飲沒辦法再加冰塊喔！");   //無法加到購物車的情況
            //        combo冰塊.SelectedIndex = 0;
            //    }

            //    else if (((select飲品 > 0) && (select飲品 < GlobalVar.list熱飲品項.Count)) && (combo加料.SelectedIndex > 0))
            //    {
            //        MessageBox.Show("熱飲不能另外加料喔！");   //無法加到購物車的情況
            //        combo加料.SelectedIndex = 0;
            //    }

            //    else if ((select飲品 > 0) && (select飲品 < GlobalVar.list熱飲品項.Count))    //熱飲索引值在listbox中 1~7  0為熱飲標題
            //    {//選到熱飲 可加到購物車
            //        所選品項 = GlobalVar.list熱飲品項[select飲品];
            //        所選單價 = GlobalVar.list熱飲價格[select飲品];
            //    }

            //    else if ((select飲品 > GlobalVar.list熱飲品項.Count) && (select飲品 < listBox所有品項.Items.Count))    //冷飲索引值在listbox中 9~18  8為冷飲標題
            //    {//選到冷飲 可加到購物車
            //        所選品項 = GlobalVar.list冷飲品項[select飲品 - GlobalVar.list熱飲品項.Count];
            //        所選單價 = GlobalVar.list冷飲價格[select飲品 - GlobalVar.list熱飲品項.Count] + list加料價格[combo加料.SelectedIndex];
            //    }

            //}

            //lbl單價.Text = string.Format("{0}元", 所選單價);
            //計算所選品項總價();

            //int select蛋糕 = listBox蛋糕品項.SelectedIndex;

            //if (select蛋糕 >= 0 && select蛋糕 < GlobalVar.list蛋糕品項.Count)
            //{
            //    if (select蛋糕 == 0)
            //    {
            //        MessageBox.Show("這個不能喝！請重新選擇");
            //        return;
            //    }
            //    所選品項 = GlobalVar.list蛋糕品項[select蛋糕];
            //    所選單價 = GlobalVar.list蛋糕價格[select蛋糕] + list加料價格[combo加料.SelectedIndex];

            //    lbl單價.Text = String.Format("{0}元", 所選單價);
            //    計算所選品項總價();
            //}
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

            計算所選品項總價();
        }


        private void btn加入購物車_Click(object sender, EventArgs e)
        {
            if (txt訂購人.Text != "") 
            {
                ArrayList 訂購單品資訊 = new ArrayList();
                訂購單品資訊.Add(所選品項);
                訂購單品資訊.Add(所選單價);
                訂購單品資訊.Add(所選數量);
                訂購單品資訊.Add(所選品項總價);
                訂購單品資訊.Add(所選甜度);
                訂購單品資訊.Add(所選冰塊);
                訂購單品資訊.Add(所選加料);

                GlobalVar.訂購人資訊 = txt訂購人.Text;
                GlobalVar.list訂購品項資料.Add(訂購單品資訊);

                if (radio外帶.Checked == true) 
                {
                    GlobalVar.is外帶 = true;
                }

                if (chk買購物袋.Checked == true) 
                {
                    GlobalVar.is買購物袋 = true;
                }

                MessageBox.Show("所選品項已加入購物車");
            }
            else
            {
                MessageBox.Show("請輸入訂購人");
            }


        }

        private void btn查看購物車_Click(object sender, EventArgs e)
        {
            FormOrderLists myOrderListForm = new FormOrderLists();

            myOrderListForm.訂購人資訊 = txt訂購人.Text;

            myOrderListForm.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {   // 會執行多次，當回到此表單可用的時候執行
            // Form_Activated 會執行多次 
            // Form Load 只會執行一次
            // EX：更新Form1的時候

            Console.WriteLine("Form Activiated .....");

        }

        void 顯示listVIew_飲品列表模式()
        {
            listView飲品選項.Clear();
            listView飲品選項.LargeImageList = null;
            listView飲品選項.SmallImageList = null;
            listView飲品選項.View = View.Details;
            listView飲品選項.Columns.Add("id", 100);
            listView飲品選項.Columns.Add("pname", 200);
            listView飲品選項.Columns.Add("price", 100);
            listView飲品選項.Columns.Add("pcategory", 100);
            listView飲品選項.GridLines = true;
            listView飲品選項.FullRowSelect = true;

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
                listView飲品選項.Items.Add(listItem);
            }
        }
 
    }
}


//WindowsFormApp6 .Net開發