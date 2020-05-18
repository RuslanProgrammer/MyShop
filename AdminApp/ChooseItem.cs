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

namespace AdminApp
{
    public partial class ChooseItem : Form
    {
        public Item item;
        public decimal amount;
        private Supply supply;
        public ChooseItem(List<Item> lst, Supply Supply)
        {
            InitializeComponent();
            ItemsGridVieww.DataSource = lst;
            supply = Supply;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) => numericUpDown1.BackColor = Color.White;

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            if (item == null)
            {
                item = ItemsGridVieww.SelectedRows[0].DataBoundItem as Item;
                if (numericUpDown1.Value != (int) numericUpDown1.Value && item.Unit == "unit")
                {
                    numericUpDown1.BackColor = Color.Red;
                }
                else
                {
                    amount = numericUpDown1.Value;
                }
            }

        }

        private void ChooseItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                item = ItemsGridVieww.SelectedRows[0].DataBoundItem as Item;
                if ((numericUpDown1.Value != (int) numericUpDown1.Value && item.Unit == "unit") ||numericUpDown1.Value == 0)
                {
                    numericUpDown1.BackColor = Color.Red;
                    e.Cancel = true;
                }
                else
                    amount = numericUpDown1.Value;
            }
        }

        private void ChooseItem_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ItemsGridVieww.RowCount; i++)
            {
                if ((decimal) ItemsGridVieww.Rows[i].Cells[3].Value < 500)
                {
                    ItemsGridVieww.Rows[i].Cells[0].Style.BackColor = Color.RosyBrown;
                }
                else if ((decimal) ItemsGridVieww.Rows[i].Cells[3].Value < 1000)
                {
                    ItemsGridVieww.Rows[i].Cells[0].Style.BackColor = Color.DarkGoldenrod;
                }
                else
                {
                    ItemsGridVieww.Rows[i].Cells[0].Style.BackColor = Color.LightGreen;
                }
            }
        }
    }
}
