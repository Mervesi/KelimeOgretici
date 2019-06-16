using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOgretici.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = txtUserName.Text;
            user.Password = txtPassword.Text;

            UserDataAccess userdb = new UserDataAccess();
            if (userdb.IsUserRegister(user))
            {
                //yeni form aç
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!");
            }
        }
    }
}
