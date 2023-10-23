using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0428期中
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btn訂購單_Click(object sender, EventArgs e)
        {

            FormCustomer F_customer = new FormCustomer();
            F_customer.ShowDialog();

        }

        private void btn會員資料管理_Click(object sender, EventArgs e)
        {
            Persons myForm2 = new Persons();
            myForm2.ShowDialog();
        }


        private void btn訂單管理_Click(object sender, EventArgs e)
        {
            FormOrderDetails orderDetails = new FormOrderDetails();
            orderDetails.ShowDialog();
        }

        private void btn商品管理_Click(object sender, EventArgs e)
        {
            Products ProductForm = new Products();
            ProductForm.ShowDialog();
        }
    }
}
