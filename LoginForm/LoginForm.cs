using AdminApp;
using MyShop;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UserApp;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        private bool _changed;

        public LoginForm()
        {
            Shop = new Shop();
            if(!File.Exists("shop.bin"))
                Shop.FillTest(100);
            else 
                Shop.Load();
            InitializeComponent();
        }

        public Shop Shop { get; }

        private void SignUp_Click(object sender, EventArgs e)
        {
            var su = new SignUpForm(Shop.Users, Shop.Admin);
            if (su.ShowDialog() == DialogResult.OK)
            {
                Shop.AddUser(su.Res);
                LoginBox.Text = su.Res.Name;
                PasswordBox.Text = su.Res.Password;
                _changed = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(loginText, "2<length<21, and not contain only numbers");
            toolTip2.SetToolTip(PasswordText, "length must be 4");
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            if (!CheckAdmin())
                CheckUser();
        }

        private bool CheckAdmin()
        {
            if (LoginBox.Text == Shop.Admin.Name && PasswordBox.Text == Shop.Admin.Password)
            {
                LoginBox.BackColor = Color.White;
                var adminApp = new AdminForm(Shop);
                this.Hide();
                adminApp.ShowDialog();
                if (adminApp.ToLogin)
                    this.Show();
                else
                    this.Close();
                return true;
            }
            return false;
        }

        private void CheckUser()
        {
            foreach (var shopUser in Shop.Users)
            {
                if (LoginBox.Text == shopUser.Name)
                {
                    if (PasswordBox.Text == shopUser.Password)
                    {
                        var userApp = new UserForm(Shop, shopUser);
                        this.Hide();
                        userApp.ShowDialog();
                        if (userApp.ToLogin)
                            this.Show();
                        else
                            this.Close();
                        return;
                    }
                    PasswordBox.BackColor = Color.Red;
                }
            }
            LoginBox.BackColor = Color.Red;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_changed)
                Shop.Save();
        }

        private void SignIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
                SignIn_Click(sender, EventArgs.Empty);
        }
    }
}