using AdminApp;
using MyShop;
using System;
using System.Drawing;
using System.Windows.Forms;
using UserApp;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        private Shop shop;
        public LoginForm()
        {
            shop = new Shop();
            shop.Load();
            InitializeComponent();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            var su = new SignUpForm(shop.Users, shop.admin);
            if (su.ShowDialog() == DialogResult.OK)
            {
                shop.AddUser(su.res);
                LoginBox.Text = su.res.Name;
                PasswordBox.Text = su.res.Password;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(loginText, "2<length<21, and not contain only numbers");
            toolTip2.SetToolTip(PasswordText, "length must be 4");
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                CheckAdmin();
                CheckUser();
            }
            else
            {
                shop.Save();
            }
        }

        private void CheckAdmin()
        {
            if (LoginBox.Text == shop.admin.Name && PasswordBox.Text == shop.admin.Password)
            {
                var adminApp = new AdminForm();
                adminApp.Show();
                this.Hide();
            }
        }

        private void CheckUser()
        {
            foreach (var shopUser in shop.Users)
            {
                if (LoginBox.Text == shopUser.Name)
                {
                    if (PasswordBox.Text == shopUser.Password)
                    {
                        var userApp = new UserForm();
                        userApp.Show();
                        this.Hide();
                    }
                    PasswordBox.BackColor = Color.Red;
                }
            }
            LoginBox.BackColor = Color.Red;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
