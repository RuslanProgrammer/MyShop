using MyShop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class SignUpForm : Form
    {
        private readonly List<User> users;
        public User res;
        public SignUpForm(List<User> _users, Admin admin)
        {
            users = _users;
            res = new User(admin.Name, admin.Password);
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (loginBox.Text.Length <= 3 || loginBox.Text.Length >= 20 || Int32.TryParse(loginBox.Text, out i))
                loginBox.BackColor = Color.Red;
            else loginBox.BackColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (passwordBox.Text.Length != 4) passwordBox.BackColor = Color.Red;
            else passwordBox.BackColor = Color.White;
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                CheckLogin(loginBox, e);
                CheckPassword(passwordBox, e); 
                res = new User(loginBox.Text, passwordBox.Text);
            }
        }

        private void CheckLogin(Control c, FormClosingEventArgs e)
        {
            if (c.BackColor == Color.Red || loginBox.Text == res.Name && passwordBox.Text == res.Password || loginBox.Text == res.Name)
            {
                c.BackColor = Color.Red;
                e.Cancel = true;
                return;
            }
            foreach (var shopUser in users)
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
            {
                e.Cancel = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(loginText, "2<length<21, and not contain only numbers");
            toolTip2.SetToolTip(passwordText, "length must be 4");
        }
    }
}
