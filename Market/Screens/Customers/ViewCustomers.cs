using Market.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Screens.Customers
{
    public partial class ViewCustomers : Form
    {

        MarketEntities DB = new MarketEntities();

        int id;
        Market.DB.Customer result;

        public ViewCustomers()
        {
            InitializeComponent();
        }

        private void ViewCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet3.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter1.Fill(this.marketDataSet3.Customer);
            dataGridView1.DataSource = DB.Customers.OrderByDescending(x => x.Dues).ToList();

        }


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TxtSearchName.Text == String.Empty)
            {
                dataGridView1.DataSource = DB.Customers.Where
                    (x => x.Phone == TxtSearchPhone.Text).OrderByDescending(x => x.Dues).ToList();
            }
            else
            {
                dataGridView1.DataSource = DB.Customers.Where
                    (x => x.Phone == TxtSearchPhone.Text || x.Name.Contains(TxtSearchName.Text))
                    .OrderByDescending(x => x.Dues).ToList();
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.Customers.OrderByDescending(x => x.Dues).ToList();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            result.Name = TxtName.Text;
            result.Address = TxtAddress.Text;
            result.Notes = TxtNotes.Text;
            result.Phone = TxtPhone.Text;
            decimal d = decimal.Parse(TxtFinance.Text);
            result.Dues = d;
            if (result.isActive == null)
            {
                result.isActive = false;
            }
            result.isActive = checkBoxActive.Checked;


            DB.SaveChanges();

            dataGridView1.DataSource = DB.Customers.OrderByDescending(x => x.Dues).ToList();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DB.Customers.Remove(result);
            DB.SaveChanges();

            dataGridView1.DataSource = DB.Customers.OrderByDescending(x => x.Dues).ToList();

        }


        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                result = DB.Customers.SingleOrDefault(x => x.Id == id);

                TxtName.Text = result.Name;
                TxtPhone.Text = result.Phone;
                TxtFinance.Text = result.Dues.ToString();
                TxtNotes.Text = result.Notes;
                TxtAddress.Text = result.Address;
                checkBoxActive.Checked = (bool)result.isActive;
            }
            catch { };

        }
    }
}
