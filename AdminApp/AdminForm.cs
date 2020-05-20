using MyShop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class AdminForm : Form
    {
        private Shop shop;
        private bool IsChanged;
        public bool ToLogin;
        private List<object> SupplyList = new List<object>();

        public AdminForm(Shop shop)
        {
            InitializeComponent();
            this.shop = shop;
            itemBindingSource.DataSource = shop.Items;
            foreach (var shopSupply in shop.Supplies)
            {
                var temp = new {shopSupply.DateTimeEnd, shopSupply.Portions.Count};
                SupplyList.Add(temp);
            }
            supplyBindingSource.DataSource = SupplyList;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SuppliesGridView.Rows.Count; i++)
            {
                    if ((DateTime) SuppliesGridView.Rows[i].Cells[0].Value < DateTime.Now)
                        SuppliesGridView.Rows[i].Cells[0].Style.BackColor = Color.Green;
                    else
                        SuppliesGridView.Rows[i].Cells[0].Style.BackColor = Color.IndianRed;
                
            }
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
            IsChanged = false;
            itemBindingSource.ResetBindings(false);
            foreach (var shopSupply in shop.Supplies)
            {
                var temp = new { shopSupply.DateTimeEnd, shopSupply.Portions.Count };
                SupplyList.Add(temp);
            }
            supplyBindingSource.ResetBindings(false);
            Form1_Load(sender, e);
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

        private void ItemsGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
            => editToolStripMenuItem_Click(sender, EventArgs.Empty);

        private void supplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editToolStripMenuItem1.Enabled = deleteToolStripMenuItem1.Enabled =
                SuppliesGridView.SelectedRows.Count > 0 &&
                (DateTime) SuppliesGridView.CurrentRow.Cells[0].Value - TimeSpan.FromDays(2) <=
                DateTime.Now &&
                (DateTime) SuppliesGridView.CurrentRow.Cells[0].Value - TimeSpan.FromDays(2) + TimeSpan.FromHours(2) >= DateTime.Now;
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var supplyform = new SupplyForm(shop.Items);
            if (supplyform.ShowDialog() == DialogResult.OK)
            {
                shop.AddSupplyFirst(supplyform.Supply);
                SupplyList.Insert(0,new { supplyform.Supply.DateTimeEnd, supplyform.Supply.Portions.Count});
                supplyBindingSource.ResetBindings(false);
                IsChanged = true;
                
                SuppliesGridView.Rows[0].Selected = true;
                SuppliesGridView.FirstDisplayedScrollingRowIndex = 0;
                Form1_Load(sender, e);
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DateTime dt = (DateTime)SuppliesGridView.CurrentRow.Cells[0].Value;
            Supply supply = shop.Supplies[0];
            foreach (var shopSupply in shop.Supplies)
            {
                if (shopSupply.DateTimeEnd == dt)
                {
                    supply = shopSupply;
                    break;
                }
            }

            supply = shop.Supplies[SuppliesGridView.CurrentRow.Index];
            var supplyform = new SupplyForm(supply, shop.Items);
            if (supplyform.ShowDialog() == DialogResult.OK)
            {
                supplyBindingSource.ResetBindings(false);
                IsChanged = true;
                Form1_Load(sender, e);
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var del = (DateTime)SuppliesGridView.CurrentRow.Cells[0].Value;
            var ask = MessageBox.Show($"Delete supplies to {del} ?", "", MessageBoxButtons.YesNo);
            if (ask == DialogResult.Yes)
            {
                shop.Supplies.RemoveAt(SuppliesGridView.CurrentRow.Index);
                SupplyList.RemoveAt(SuppliesGridView.CurrentRow.Index);
                supplyBindingSource.ResetBindings(false);
                IsChanged = true;
                Form1_Load(sender, e);
            }
        }
    }
}
