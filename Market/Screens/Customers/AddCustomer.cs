using Market.DB;
using System;
using System.Windows.Forms;

namespace Market.Screens.Customers
{
    public partial class AddCustomer : Form
    {
        MarketEntities DB = new MarketEntities();
        DB.Customer customer = new DB.Customer();

        public AddCustomer()
        {
            InitializeComponent();
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtCustomerName.Text == String.Empty)
            {
                MessageBox.Show("برجاء كتابة اسم العميل");
                return;
            }

            customer.Name = TxtCustomerName.Text;
            customer.Address = TxtCustomerAdress.Text;
            customer.Notes = TxtCustomerNotes.Text;
            customer.Phone = TxtCustomerPhone.Text;
            customer.isActive = true;
            decimal d = decimal.Parse(TxtCustomerFinance.Text);
            customer.Dues = d;

            customer.isActive = true;

            DB.Customers.Add(customer);

            DB.SaveChanges();

            MessageBox.Show("تم الحفظ");


        }
    }
}
