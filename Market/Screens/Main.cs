using Market.Screens.Customers;
using Market.Screens.Product;
using Market.Screens.User;
using System;
using System.Windows.Forms;

namespace Market.Screens
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافةمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Signin signin = new Signin();
            signin.Show();
        }

        private void اضافةمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void عرضالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProducts viewProducts = new ViewProducts();
            viewProducts.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewProducts viewProducts = new ViewProducts();
            viewProducts.Show();
        }

        private void اضافةعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void عرضالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCustomers viewCustomers = new ViewCustomers();
            viewCustomers.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewCustomers viewCustomers = new ViewCustomers();
            viewCustomers.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.Show();
        }
    }
}
