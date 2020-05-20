using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using MyShop;

namespace UserApp
{
    public partial class UserForm : Form
    {
        public Shop Shop;
        public bool ToLogin;
        public User CurUser;
        private bool IsChanged;
        private List<Portion> portions = new List<Portion>();
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
            var im = new DataGridViewImageColumn {ImageLayout = DataGridViewImageCellLayout.Zoom};
            ItemsGridView.Columns.Add(im);
            ItemsGridView.Columns[0].HeaderText = "Image";
            ItemsGridView.Columns.Add("Name", "Name");
            ItemsGridView.Columns.Add("Price", "Price");
            ItemsGridView.Columns[0].Width = 70;
            ItemsGridView.Columns[1].Width = 138;
            ItemsGridView.Columns[2].Width = 60;
            FillItemTable();
        }

        private void FillItemTable(bool flag = true)
        {
            foreach (var portion in portions)
            {
                if ((flag || portion.Item.Name.ToLower().Contains((SearchItemBox.Text).ToLower())))
                {
                    AddToBasket(portion);
                }
            }
        }

        private void AddToBasket(Portion portion)
        {
            Font font1 = new Font("Microsoft Sans Serif", 15);
            Font font2 = new Font("Microsoft Sans Serif", 10);
            ItemsGridView.Rows.Add(portion.Item.Image, portion.Item.Name, portion.Item.Price[portion.Item.Price.Count - 1]);
            ItemsGridView.Rows[ItemsGridView.Rows.Count - 1].Height = 70;
            ItemsGridView.Rows[ItemsGridView.Rows.Count - 1].Cells[1].Style.Font = font1;
            ItemsGridView.Rows[ItemsGridView.Rows.Count - 1].Cells[2].Style.Font = font2;
        }

        private void SearchItemBox_TextChanged(object sender, EventArgs e)
        {
            ItemsGridView.Rows.Clear();
            FillItemTable(false);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemform = new ChooseItem(Shop.Items);
            if (itemform.ShowDialog() == DialogResult.OK)
            {
                portions.Add(itemform.Portion);
                AddToBasket(itemform.Portion);

                IsChanged = true;

                var ind = ItemsGridView.Rows.Count - 1;
                ItemsGridView.Rows[ind].Selected = true;
                ItemsGridView.FirstDisplayedScrollingRowIndex = ind;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemform = new ChooseItem(portions[ItemsGridView.CurrentRow.Index]);
            if (itemform.ShowDialog() == DialogResult.OK)
            {
                IsChanged = true;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var del = ItemsGridView.CurrentRow.Cells[1].Value;
            var ask = MessageBox.Show($"Delete {del} ?", "", MessageBoxButtons.YesNo);
            if (ask == DialogResult.Yes)
            {
                portions.Remove(portions[ItemsGridView.CurrentRow.Index]);
                ItemsGridView.Rows.RemoveAt(ItemsGridView.CurrentRow.Index);
                IsChanged = true;
            }
        }
    }
}
