using MyShop;
using System;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class AdminForm : Form
    {
        private Shop shop;
        private bool IsChanged = true;
        public bool ToLogin = false;

        public AdminForm(Shop shop)
        {
            this.shop = shop;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitDesktop_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsChanged)
                return;
            var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Cancel)
                e.Cancel = true;
            else if (res == DialogResult.Yes)
                shop.Save();
        }

        private void ExitToLogin_Click(object sender, EventArgs e)
        {
            ToLogin = true;
            Close();
        }
    }
}
