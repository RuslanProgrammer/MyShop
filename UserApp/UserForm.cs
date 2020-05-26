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
        private List<Portion> history = new List<Portion>();
        private List<Portion> basket = new List<Portion>();
        public UserForm(Shop shop, User user)
        {
            Shop = shop;
            CurUser = user;
            InitializeComponent();
            history = user.History;
            history.Reverse();
            basket = user.Basket;
                    
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Hello, {CurUser.Name}";
            CreateTable(ItemsGridView);
            FillItemTable();
            CreateTable(HistoryGridView);
            FillHistoryTable();
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

        private void CreateTable(DataGridView table)
        {
            var im = new DataGridViewImageColumn {ImageLayout = DataGridViewImageCellLayout.Zoom};
            table.Columns.Add(im);
            table.Columns[0].HeaderText = "Image";
            table.Columns.Add("Name", "Name");
            table.Columns.Add("Price", "Price");
            table.Columns[0].Width = 70;
            table.Columns[1].Width = 138;
            table.Columns[2].Width = 60;
        }

        private void FillItemTable(bool flag = true)
        {
            foreach (var portion in basket)
            {
                if ((flag || portion.Item.Name.ToLower().Contains((SearchItemBox.Text).ToLower())))
                {
                    AddToBasket(portion, ItemsGridView);
                }
            }
        }

        private void AddToBasket(Portion portion, DataGridView table)
        {
            Font font1 = new Font("Microsoft Sans Serif", 15);
            Font font2 = new Font("Microsoft Sans Serif", 10);
            table.Rows.Add(portion.Item.Image, portion.Item.Name, portion.Item.Price[portion.Item.Price.Count - 1]);
            table.Rows[table.Rows.Count - 1].Height = (int)(((double)70 / (double)424) * ItemsGridView.Height);
            table.Rows[table.Rows.Count - 1].Cells[1].Style.Font = font1;
            table.Rows[table.Rows.Count - 1].Cells[2].Style.Font = font2;
        }

        private void SearchItemBox_TextChanged(object sender, EventArgs e)
        {
            ItemsGridView.Rows.Clear();
            FillItemTable(false);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemform = new ChooseItem(Shop.Items, basket);
            if (itemform.ShowDialog() == DialogResult.OK)
            {
                basket.Add(itemform.Portion);
                AddToBasket(itemform.Portion, ItemsGridView);

                IsChanged = true;

                var ind = ItemsGridView.Rows.Count - 1;
                ItemsGridView.Rows[ind].Selected = true;
                ItemsGridView.FirstDisplayedScrollingRowIndex = ind;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemform = new ChooseItem(basket[ItemsGridView.CurrentRow.Index]);
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
                basket.Remove(basket[ItemsGridView.CurrentRow.Index]);
                ItemsGridView.Rows.RemoveAt(ItemsGridView.CurrentRow.Index);
                IsChanged = true;
            }
        }

        private void FillHistoryTable()
        {
            foreach (var portion in history)
            {
                AddToBasket(portion, HistoryGridView);
            }
        }

        private void HistoryGridView_SelectionChanged(object sender, EventArgs e)
        {
            HistoryGridView.CurrentRow.Selected = false;
        }

        private void ItemsGridView_SizeChanged(object sender, EventArgs e)
        {
            ItemsGridView.Columns[0].Width = (int)(((double)70 / (double)289) * ItemsGridView.Width);
            ItemsGridView.Columns[1].Width = (int)(((double)138 / (double)289) * ItemsGridView.Width);
            ItemsGridView.Columns[2].Width = (int)(((double)60 / (double)289) * ItemsGridView.Width);
            for (int i = 0; i < ItemsGridView.RowCount; i++)
            {
                ItemsGridView.Rows[i].Height = (int)(((double)70 / (double)424) * ItemsGridView.Height);
            }
        }

        private void Finishbutton_Click(object sender, EventArgs e)
        {
            if (basket.Count == 0)
                MessageBox.Show($"You haven't ordered anything yet");
            else
            {
                var res = MessageBox.Show("That's all?", "", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    foreach (var portion in basket)
                    {
                        foreach (var shopItem in Shop.Items)
                        {
                            if (portion.Item.Name == shopItem.Name)
                            {
                                shopItem.Sold += portion.Amount;
                                break;
                            }
                        }
                    }
                    string str = "Your order:\n\n";
                    foreach (var portion in basket)
                    {
                        str += $"{portion.Item.Name} × {portion.Amount}\n";
                    }
                    MessageBox.Show(str);
                    CurUser.History.AddRange(basket);
                    CurUser.Basket.Clear();
                    Shop.Save();
                    IsChanged = false;
                    Close();
                }
            }
        }

        private void basketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editToolStripMenuItem.Enabled =
                deleteToolStripMenuItem.Enabled =
                    ItemsGridView.SelectedRows.Count > 0;
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("https://github.com/RuslanProgrammer/MyShop");

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("Shop documentation\nLook how to use Shop to buy products in specification!");
    }
}
