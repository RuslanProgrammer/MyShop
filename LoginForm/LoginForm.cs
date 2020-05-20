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
        private Shop _shop;
        private bool changed = false;
        public LoginForm()
        {
            _shop = new Shop();
            _shop.Load();
            _shop.FillTest(100);
            InitializeComponent();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            var su = new SignUpForm(_shop.Users, _shop.admin);
            if (su.ShowDialog() == DialogResult.OK)
            {
                _shop.AddUser(su.res);
                LoginBox.Text = su.res.Name;
                PasswordBox.Text = su.res.Password;
                changed = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(loginText, "2<length<21, and not contain only numbers");
            toolTip2.SetToolTip(PasswordText, "length must be 4");
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            if(!CheckAdmin())
                CheckUser();
        }

        private bool CheckAdmin()
        {
            if (LoginBox.Text == _shop.admin.Name && PasswordBox.Text == _shop.admin.Password)
            {
                var adminApp = new AdminForm(_shop);
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
            foreach (var shopUser in _shop.Users)
            {
                if (LoginBox.Text == shopUser.Name)
                {
                    if (PasswordBox.Text == shopUser.Password)
                    {
                        var userApp = new UserForm(_shop, shopUser);
                        this.Hide();
                        userApp.ShowDialog();
                        if(userApp.ToLogin)
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
            if(changed)
                _shop.Save();
        }

        private void signIn_KeyDown(object sender, KeyEventArgs e)
        {
            if(Keys.Enter == e.KeyCode)
                signIn_Click(sender, EventArgs.Empty);
        }
    }
}
