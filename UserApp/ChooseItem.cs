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
    public partial class ChooseItem : Form
    {
        private readonly List<Item> _items;
        private List<Portion> alreade;
        public Portion Portion;
        private bool inedit;
        private ChooseItem(List<Item> items)
        {
            InitializeComponent();
            _items = items;
        }

        public ChooseItem(List<Item> items, List<Portion> portions) : this(items)
        {
            alreade = portions;
        }
        public ChooseItem(Portion portion) : this(new List<Item>(){portion.Item})
        {
            Portion = portion;
            AmountUpDown.Value = portion.Amount;
            SearchItemBox.Visible = false;
            inedit = true;
        }

        private void ChooseItem_Load(object sender, EventArgs e)
        {
            CreateItemTable();
        }
        private void CreateItemTable()
        {
            var im = new DataGridViewImageColumn { ImageLayout = DataGridViewImageCellLayout.Zoom };
            AllItemTable.Columns.Add(im);
            AllItemTable.Columns[0].HeaderText = "Image";
            AllItemTable.Columns.Add("Name", "Name");
            AllItemTable.Columns.Add("Price", "Price");
            AllItemTable.Columns[0].Width = 70;
            AllItemTable.Columns[1].Width = 138;
            AllItemTable.Columns[2].Width = 60;
            FillItemTable();
        }
        private void FillItemTable(bool flag = true)
        {
            int i = 0;
            foreach (var shopItem in _items)
            {
                AddToBasket(shopItem);
                
                if ((!inedit && alreade.Select(x => x.Item.Name).Contains(shopItem.Name)) || !(shopItem.Available > 0 && (flag || shopItem.Name.ToLower().Contains((SearchItemBox.Text).ToLower()))))
                {
                    AllItemTable.Rows[i].Visible = false;
                }
                i++;
            }
        }
        private void AddToBasket(Item item)
        {
            Font font1 = new Font("Microsoft Sans Serif", 15);
            Font font2 = new Font("Microsoft Sans Serif", 10);
            AllItemTable.Rows.Add(item.Image, item.Name, item.Price[item.Price.Count - 1]);
            AllItemTable.Rows[AllItemTable.Rows.Count - 1].Height = 70;
            AllItemTable.Rows[AllItemTable.Rows.Count - 1].Cells[1].Style.Font = font1;
            AllItemTable.Rows[AllItemTable.Rows.Count - 1].Cells[2].Style.Font = font2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AllItemTable.Rows.Clear();
            FillItemTable(false);
        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            if (Portion == null) Portion = new Portion {Item = _items[AllItemTable.SelectedRows[0].Index]};
            Portion.Amount = AmountUpDown.Value;
        }

        private void ChooseItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (AmountUpDown.Value == 0 ||
                    (AmountUpDown.Value != (int) AmountUpDown.Value && Portion.Item.Unit == "unit"))
                {
                    AmountUpDown.BackColor = Color.Red;
                    e.Cancel = true;
                }
            }
        }

        private void AmountUpDown_ValueChanged(object sender, EventArgs e) => AmountUpDown.BackColor = Color.White;

        private void AllItemTable_SelectionChanged(object sender, EventArgs e)
        {
            AmountUpDown.Maximum = _items[AllItemTable.CurrentRow.Index].Available;
        }
    }
}
