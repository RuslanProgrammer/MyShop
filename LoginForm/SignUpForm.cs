using MyShop;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class SignUpForm : Form
    {
        private readonly List<User> _users;

        public SignUpForm(List<User> users, Admin admin)
        {
            _users = users;
            Res = new User(admin.Name, admin.Password);
            InitializeComponent();
        }

        public User Res { private set; get; }

        private void textBox1_TextChanged(object sender, EventArgs e) =>
            loginBox.BackColor =
                loginBox.Text.Length <= 3 || loginBox.Text.Length >= 20 || Int32.TryParse(loginBox.Text, out _)
                    ? Color.Red
                    : Color.White;

        private void textBox2_TextChanged(object sender, EventArgs e) =>
            passwordBox.BackColor = passwordBox.Text.Length != 4 ? Color.Red : Color.White;

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                CheckLogin(loginBox, e);
                CheckPassword(passwordBox, e);
                Res = new User(loginBox.Text, passwordBox.Text);
            }
        }

        private void CheckLogin(Control c, FormClosingEventArgs e)
        {
            if (c.BackColor == Color.Red ||
                loginBox.Text == Res.Name && passwordBox.Text == Res.Password ||
                loginBox.Text == Res.Name)
            {
                c.BackColor = Color.Red;
                e.Cancel = true;
                return;
            }
            foreach (var shopUser in _users)
            {
                if (shopUser.Name == c.Text)
                {
                    c.BackColor = Color.Red;
                    e.Cancel = true;
                    break;
                }
            }
        }

        private void CheckPassword(Control c, FormClosingEventArgs e)
        {
            if (c.BackColor == Color.Red)
                e.Cancel = true;
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(loginText, "2<length<21, and not contain only numbers");
            toolTip2.SetToolTip(passwordText, "length must be 4");
        }
    }
}