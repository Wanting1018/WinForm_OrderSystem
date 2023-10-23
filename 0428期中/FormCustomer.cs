using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0428期中
{
    public partial class FormCustomer : Form
    {

        List<string> list內用桌號 = new List<string>();
        string 所選桌號 = "";
        bool is外帶 = false;



        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            //內用桌號
            list內用桌號.Add("");
            list內用桌號.Add("第⓵桌");
            list內用桌號.Add("第⓶桌");
            list內用桌號.Add("第⓷桌");
            list內用桌號.Add("第⓸桌");
            list內用桌號.Add("第⓹桌");
            list內用桌號.Add("第⓺桌");


            foreach (string item in list內用桌號)
            {
                combo內用桌號.Items.Add(item);
            }

            combo內用桌號.SelectedIndex = 0;
            所選桌號 = list內用桌號[combo內用桌號.SelectedIndex];  //預設值

            radio外帶.Checked = true;
            is外帶 = true;
        }

        private void txt訂購人_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.訂購人資訊 = txt訂購人.Text;
        }

        private void btn開始點餐_Click(object sender, EventArgs e)
        {
            if (txt訂購人.Text != "")
            {
                if (GlobalVar.is外帶 == false)
                {
                    if (combo內用桌號.SelectedIndex < 1)
                    {
                        MessageBox.Show("請選擇桌號");
                    }
                }

                歡迎訊息();
                FormMenu menu = new FormMenu();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("請先輸入訂購人資料再進行點餐喔✍");
            }         
        }

        private void radio內用_CheckedChanged(object sender, EventArgs e)
        {

            GlobalVar.is外帶 = false;       
            
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

        void 歡迎訊息()
        {
            MessageBox.Show("★☆★☆★☆★☆  歡迎光臨！ 今天想來點甚麼？ ★☆★★☆★☆");
        }
    }
}
