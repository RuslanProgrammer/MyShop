using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyShop;

namespace UserApp
{
    public partial class UserForm : Form
    {
        public Shop Shop;
        public bool ToLogin;
        public User CurUser;
        private bool IsChanged;
        public UserForm(Shop shop, User user)
        {
            Shop = shop;
            CurUser = user;
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Hello, {CurUser.Name}";
            CreateItemTable();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shop.Load();
            /////////////////////
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shop.Save();
            IsChanged = false;
        }

        private void toDesktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toSignInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToLogin = true;
            Close();
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsChanged)
                return;
            var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Cancel)
                e.Cancel = true;
            else if (res == DialogResult.Yes)
                Shop.Save();
        }

        private void CreateItemTable()
        {
            var im = new DataGridViewImageColumn();
            im.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ItemsGridView.Columns.Add(im);
            ItemsGridView.Columns[0].HeaderText = "Image";
            ItemsGridView.Columns.Add("Name", "Name");
            ItemsGridView.Columns.Add("Price", "Price");
            ItemsGridView.Columns[0].Width = 70;
            ItemsGridView.Columns[1].Width = 138;
            ItemsGridView.Columns[2].Width = 60;
            int i = 0;
            Font font = new Font("Microsoft Sans Serif", 18);
            foreach (var shopItem in Shop.Items)
            {
                if (shopItem.Available > 0)
                {
                    ItemsGridView.Rows.Add(shopItem.Image, shopItem.Name, shopItem.Price[shopItem.Price.Count - 1]);
                    ItemsGridView.Rows[i].Height = 70;
                    ItemsGridView.Rows[i].Cells[1].Style.Font = font;
                    ItemsGridView.Rows[i].Cells[2].Style.Font = font;
                    i++;
                }
            }
        }
    }
}
