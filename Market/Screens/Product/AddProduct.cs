using Market.DB;
using System;
using System.IO;
using System.Windows.Forms;

namespace Market.Screens.Product
{
    public partial class AddProduct : Form
    {
        MarketEntities DB = new MarketEntities();
        DB.Product product = new DB.Product();

        bool hasImage = false;
        String imagePath = "";
        public AddProduct()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtParcode.Text == "" || TxtProductName.Text == "" || TxtPrice.Text == "")
            {
                MessageBox.Show("برجاء استكمال البيانات");
                return;
            }
            product.ParCode = TxtParcode.Text;
            product.Name = TxtProductName.Text;
            product.Notes = TxtNotes.Text;

            Decimal p;
            int q;
            Decimal.TryParse(TxtPrice.Text, out p);
            int.TryParse(TxtQuantity.Text, out q);
            product.Price = p;
            product.Quantity = q;


            DB.Products.Add(product);
            DB.SaveChanges();


            if (hasImage)
            {
                String imageSaveLocation = Environment.CurrentDirectory + "\\Images\\Products\\" + product.Id + ".png";

                File.Copy(imagePath, imageSaveLocation);
                product.Image = imageSaveLocation;

                DB.SaveChanges();
            }

            MessageBox.Show("تم الحفظ");

            TxtParcode.Text = "";
            TxtProductName.Text = "";
            TxtPrice.Text = "";
            TxtQuantity.Text = "";
            TxtNotes.Text = "";
            pictureBox1.ImageLocation = "";
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
    }
}
