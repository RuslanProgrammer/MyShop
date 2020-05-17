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
            InitializeComponent();
            this.shop = shop;
            itemBindingSource.DataSource = shop.Items;
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

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shop.Load();
            itemBindingSource.ResetBindings(false);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shop.Save();
            IsChanged = false;
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editToolStripMenuItem.Enabled =
                deleteToolStripMenuItem.Enabled =
                    ItemsGridView.SelectedRows.Count > 0;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemform = new ItemForm(shop.Items);
            if (itemform.ShowDialog() == DialogResult.OK)
            {
                shop.AddItem(itemform.Item);
                itemBindingSource.ResetBindings(false);
                IsChanged = true;

                var ind = ItemsGridView.Rows.Count - 1;
                ItemsGridView.Rows[ind].Selected = true;
                ItemsGridView.FirstDisplayedScrollingRowIndex = ind;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemform = new ItemForm(ItemsGridView.SelectedRows[0].DataBoundItem as Item, shop.Items);
            if (itemform.ShowDialog() == DialogResult.OK)
            {
                itemBindingSource.ResetBindings(false);
                IsChanged = true;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var del = ItemsGridView.SelectedRows[0].DataBoundItem as Item;
            var ask = MessageBox.Show($"Delete {del.Name} ?", "", MessageBoxButtons.YesNo);
            if (ask == DialogResult.Yes)
            {
                shop.Items.Remove(del);
                itemBindingSource.ResetBindings(false);
                IsChanged = true;
            }
        }
    }
}
