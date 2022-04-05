using Market.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Screens.User
{
    public partial class Signin : Form
    {
        MarketEntities DB = new MarketEntities();
        String imagePath = "";
        bool hasImage = false;

        DB.User user = new DB.User();
        public Signin()
        {
            InitializeComponent();

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textUser.Text == String.Empty || textPassword.Text == String.Empty)
            {
                MessageBox.Show("برجاء استكمال البيانات");
                return;
            }

            user.User_name = textUser.Text;
            user.Password = textPassword.Text;

            DB.Users.Add(user);
            DB.SaveChanges();
            String imageSaveLocation = Environment.CurrentDirectory + "\\Images\\Users\\" + user.Id + ".png";

            if (hasImage)
            {
                File.Copy(imagePath, imageSaveLocation);
                user.Image = imageSaveLocation;

                DB.SaveChanges();
            }

            MessageBox.Show("تم الحفظ");

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
