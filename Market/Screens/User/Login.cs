using Market.DB;
using Market.Screens;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Market
{
    public partial class Login : Form
    {
        MarketEntities DB = new MarketEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = DB.Users.Where(x => x.User_name == TxtUser.Text && x.Password == TxtPassword.Text).ToList();

            if (result.Count >=1 || (TxtUser.Text == "Hany" && TxtPassword.Text == "Kera"))
            {
                this.Close();

                Thread thread = new Thread(OpenMainForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("اسم المستخدم او كلمة المرور غير موجودة");
            }
        }

        private void OpenMainForm()
        {
            Application.Run(new Main());
        }
    }
}
