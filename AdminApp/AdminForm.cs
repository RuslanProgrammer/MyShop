using MyShop;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class AdminForm : Form
    {
        private readonly Shop _shop;
        private bool _isChanged;
        private readonly List<object> _supplyList = new List<object>();
        public bool ToLogin;

        public AdminForm(Shop shop)
        {
            InitializeComponent();
            _shop = shop;
            itemBindingSource.DataSource = shop.Items;
            foreach (var shopSupply in shop.Supplies)
                _supplyList.Add(new { shopSupply.DateTimeEnd, shopSupply.Portions.Count });
            foreach (var shopSupply in shop.HistorySupplies)
                _supplyList.Add(new { shopSupply.DateTimeEnd, shopSupply.Portions.Count });
            supplyBindingSource.DataSource = _supplyList;
            userBindingSource.DataSource = shop.Users;
            CreateUserItemsTable();
        }

        private void Form1_Load(object sender, EventArgs e) =>
            ColorSupply();

        private void ColorSupply()
        {
            for (int i = 0; i < SuppliesGridView.Rows.Count; i++)
                SuppliesGridView.Rows[i].Cells[0].Style.BackColor =
                    i < _shop.Supplies.Count ? Color.IndianRed : Color.Green;
        }

        private void CreateUserItemsTable()
        {
            var im = new DataGridViewImageColumn { ImageLayout = DataGridViewImageCellLayout.Zoom };
            UserItemsGridView.Columns.Add(im);
            UserItemsGridView.Columns[0].HeaderText = "Image";
            UserItemsGridView.Columns.Add("NameUser", "Name");
            UserItemsGridView.Columns.Add("AmountUser", "Amount");
            UserItemsGridView.Columns[0].Width = 70;
            UserItemsGridView.Columns[1].Width = 138;
            UserItemsGridView.Columns[2].Width = 60;
        }

        private void ExitDesktop_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isChanged)
            {
                var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Cancel)
                    e.Cancel = true;
                else if (res == DialogResult.Yes)
                    _shop.Save();
            }
        }

        private void ExitToLogin_Click(object sender, EventArgs e)
        {
            ToLogin = true;
            Close();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _shop.Load();
            _isChanged = false;
            itemBindingSource.ResetBindings(false);
            foreach (var temp in _shop.Supplies.Select(shopSupply => new { shopSupply.DateTimeEnd, shopSupply.Portions.Count }))
                _supplyList.Add(temp);
            supplyBindingSource.ResetBindings(false);
            ColorSupply();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _shop.Save();
            _isChanged = false;
        }

        private void ItemToolStripMenuItem_Click(object sender, EventArgs e) =>
            editToolStripMenuItem.Enabled =
                deleteToolStripMenuItem.Enabled =
                    ItemsGridView.SelectedRows.Count > 0;

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemForm = new ItemForm(_shop.Items);
            if (itemForm.ShowDialog() == DialogResult.OK)
            {
                _shop.AddItem(itemForm.Item);
                itemBindingSource.ResetBindings(false);
                _isChanged = true;

                var ind = ItemsGridView.Rows.Count - 1;
                ItemsGridView.Rows[ind].Selected = true;
                ItemsGridView.FirstDisplayedScrollingRowIndex = ind;
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemForm = new ItemForm(ItemsGridView.SelectedRows[0].DataBoundItem as Item, _shop.Items);
            if (itemForm.ShowDialog() == DialogResult.OK)
            {
                itemBindingSource.ResetBindings(false);
                _isChanged = true;
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var del = ItemsGridView.SelectedRows[0].DataBoundItem as Item;
            var ask = MessageBox.Show($"Delete {del.Name} ?", "", MessageBoxButtons.YesNo);
            if (ask == DialogResult.Yes)
            {
                _shop.Items.Remove(del);
                itemBindingSource.ResetBindings(false);
                _isChanged = true;
            }
        }

        private void ItemsGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
            => EditToolStripMenuItem_Click(sender, EventArgs.Empty);

        private void SupplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editToolStripMenuItem1.Enabled = deleteToolStripMenuItem1.Enabled =
                SuppliesGridView.SelectedRows.Count > 0 &&
                (DateTime)SuppliesGridView.CurrentRow.Cells[0].Value - TimeSpan.FromDays(2) <=
                DateTime.Now &&
                (DateTime)SuppliesGridView.CurrentRow.Cells[0].Value - TimeSpan.FromDays(2) + TimeSpan.FromHours(2) >= DateTime.Now;
        }

        private void NewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var supplyForm = new SupplyForm(_shop.Items);
            if (supplyForm.ShowDialog() == DialogResult.OK)
            {
                _shop.AddSupplyFirst(supplyForm.Supply);
                _supplyList.Insert(0, new { supplyForm.Supply.DateTimeEnd, supplyForm.Supply.Portions.Count });
                supplyBindingSource.ResetBindings(false);
                _isChanged = true;

                SuppliesGridView.Rows[0].Selected = true;
                SuppliesGridView.FirstDisplayedScrollingRowIndex = 0;
                ColorSupply();
            }
        }

        private void EditToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Supply supply = _shop.Supplies[SuppliesGridView.CurrentRow.Index];
            var supplyForm = new SupplyForm(supply, _shop.Items);
            if (supplyForm.ShowDialog() == DialogResult.OK)
            {
                _supplyList[SuppliesGridView.CurrentRow.Index] = new { DateTimeEnd = DateTime.Now + TimeSpan.FromDays(2), Count = supplyForm.Supply.Portions.Count };
                supplyBindingSource.ResetBindings(false);
                _isChanged = true;
                ColorSupply();
            }
        }

        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var del = (DateTime)SuppliesGridView.CurrentRow.Cells[0].Value;
            var ask = MessageBox.Show($"Delete supplies to {del} ?", "", MessageBoxButtons.YesNo);
            if (ask == DialogResult.Yes)
            {
                _shop.Supplies.RemoveAt(SuppliesGridView.CurrentRow.Index);
                _supplyList.RemoveAt(SuppliesGridView.CurrentRow.Index);
                supplyBindingSource.ResetBindings(false);
                _isChanged = true;
                ColorSupply();
            }
        }

        private void ViewHelpToolStripMenuItem_Click(object sender, EventArgs e) =>
            MessageBox.Show("Shop documentation\nLook how to use Shop to buy products in specification!");

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e) =>
            System.Diagnostics.Process.Start("https://github.com/RuslanProgrammer/MyShop");

        private void UsersGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            User curUser = (User)userBindingSource.Current;
            UserItemsGridView.Rows.Clear();
            foreach (var portion in curUser.History)
                UserItemsGridView.Rows.Add(portion.Item.Image, portion.Item.Name, portion.Amount);
        }

        private void AdminForm_SizeChanged(object sender, EventArgs e)
        {
            UserItemsGridView.Columns[0].Width = (int)(((double)70 / (double)289) * UserItemsGridView.Width);
            UserItemsGridView.Columns[1].Width = (int)(((double)138 / (double)289) * UserItemsGridView.Width);
            UserItemsGridView.Columns[2].Width = (int)(((double)60 / (double)289) * UserItemsGridView.Width);
            UsersGridView.Columns[0].Width = (int)(((double)208 / (double)289) * UsersGridView.Width);
            UsersGridView.Columns[1].Width = (int)(((double)60 / (double)289) * UsersGridView.Width);
        }

        private void UserItemsGridView_SelectionChanged(object sender, EventArgs e) =>
            UserItemsGridView.CurrentRow.Selected = false;

        private void SuppliesGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (SuppliesGridView.CurrentRow.Index < _shop.Supplies.Count)
            {
                if ((DateTime)SuppliesGridView.CurrentRow.Cells[0].Value - TimeSpan.FromDays(2) <=
                    DateTime.Now &&
                    (DateTime)SuppliesGridView.CurrentRow.Cells[0].Value - TimeSpan.FromDays(2) +
                    TimeSpan.FromHours(2) >= DateTime.Now)

                {
                    EditToolStripMenuItem1_Click(sender, EventArgs.Empty);
                    return;
                }
                var supplyForm = new SupplyForm(_shop.Supplies[SuppliesGridView.CurrentRow.Index]);
                supplyForm.ShowDialog();
            }
            else
            {
                var supplyForm = new SupplyForm(_shop.HistorySupplies[SuppliesGridView.CurrentRow.Index - _shop.Supplies.Count]);
                supplyForm.ShowDialog();
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (var wr = new StreamWriter(Path.Combine(dialog.SelectedPath, $"MyShop.txt"), false))
                    {
                        wr.WriteLine($"Report from {DateTime.Now}");
                        wr.WriteLine($"\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nAvailable items:");
                        foreach (var item in _shop.Items)
                        {
                            var tprice = "";
                            for(int i = 0; i < item.Price.Count - 1; i++)
                                tprice += $"{item.Price[i]}, ";
                            tprice += item.Price[item.Price.Count - 1];
                            wr.WriteLine(
                                $"{item.Name}:\n    " +
                                $"Prices: {tprice}\n    " +
                                $"Available: {item.Available}\n    " +
                                $"Unit: {item.Unit}\n    " +
                                $"Sold: {item.Sold}");
                        }

                        wr.WriteLine($"\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nSupplies:\n");
                        wr.WriteLine("Not done yet:");
                        foreach (var supply in _shop.Supplies)
                        {
                            wr.WriteLine($"Order to {supply.DateTimeEnd}:");
                            foreach (var supplyPortion in supply.Portions)
                                wr.WriteLine($"    {supplyPortion.Item}, {supplyPortion.Amount}");
                        }

                        wr.WriteLine("\nDone:");
                        foreach (var supply in _shop.HistorySupplies)
                        {
                            wr.WriteLine($"Order to {supply.DateTimeEnd}:");
                            foreach (var supplyPortion in supply.Portions)
                                wr.WriteLine($"    {supplyPortion.Item.Name}, {supplyPortion.Amount}");
                        }

                        wr.WriteLine($"\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nUsers:");
                        foreach (var shopUser in _shop.Users)
                        {
                            wr.WriteLine($"{shopUser.Name} ({shopUser.Password}):");
                            foreach (var portion in shopUser.History)
                                wr.WriteLine($"    {portion.Item.Name}, {portion.Amount}");
                        }
                    }
                }
            }
        }
    }
}