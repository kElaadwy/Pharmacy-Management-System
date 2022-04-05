using Market.DB;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Market.Screens.Product
{
    public partial class ViewProducts : Form
    {
        MarketEntities DB = new MarketEntities();
        bool hasImage = false;
        String imagePath = "";

        int id;
        Market.DB.Product result;

        public ViewProducts()
        {
            InitializeComponent();
        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.marketDataSet.Products);

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == String.Empty)
            {
                dataGridView1.DataSource = DB.Products.Where
                    (x => x.ParCode == TxtParCode.Text).ToList();
            }
            else
            {
                dataGridView1.DataSource = DB.Products.Where
                    (x => x.ParCode == TxtParCode.Text || x.Name.Contains(TxtName.Text)).ToList();

            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.Products.ToList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                result = DB.Products.SingleOrDefault(x => x.Id == id);

                TxtCode.Text = result.ParCode;
                TxtProductName.Text = result.Name;
                TxtPrice.Text = result.Price.ToString();
                TxtNotes.Text = result.Notes;
                TxtQuantity.Text = result.Quantity.ToString();
                pictureBox1.ImageLocation = result.Image;
            }
            catch { };
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            result.ParCode = TxtCode.Text;
            result.Name = TxtProductName.Text;
            result.Notes = TxtNotes.Text;

            Decimal p;
            int q;
            Decimal.TryParse(TxtPrice.Text, out p);
            int.TryParse(TxtQuantity.Text, out q);
            result.Price = p;
            result.Quantity = q;

            if (hasImage)
            {
                String imageSaveLocation = Environment.CurrentDirectory + "\\Images\\Products\\" + result.Id + ".png";

                File.Copy(imagePath, imageSaveLocation,true);
                result.Image = imageSaveLocation;

            }

            DB.SaveChanges();

            dataGridView1.DataSource = DB.Products.ToList();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "اختر صورة";
            fileDialog.Filter = "Image files|*.jpg;*.png;z";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                hasImage = true;
                pictureBox1.ImageLocation = fileDialog.FileName;
                imagePath = fileDialog.FileName;
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DB.Products.Remove(result);
            DB.SaveChanges();

            dataGridView1.DataSource = DB.Products.ToList();

        }
    }
}
