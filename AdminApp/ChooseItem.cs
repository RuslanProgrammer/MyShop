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
        public Item Item;
        public decimal Amount;
        private Supply _supply;

        public ChooseItem(List<Item> lst, Supply supply)
        {
            InitializeComponent();
            ItemsGridVieww.DataSource = lst;
            _supply = supply;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) => 
            numericUpDown1.BackColor = Color.White;

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            if (Item == null)
            {
                Item = ItemsGridVieww.SelectedRows[0].DataBoundItem as Item;
                if (numericUpDown1.Value != (int) numericUpDown1.Value && Item.Unit == "unit")
                    numericUpDown1.BackColor = Color.Red;
                else
                    Amount = numericUpDown1.Value;
            }

        }

        private void ChooseItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                Item = ItemsGridVieww.SelectedRows[0].DataBoundItem as Item;
                if ((numericUpDown1.Value != (int) numericUpDown1.Value && Item.Unit == "unit") ||numericUpDown1.Value == 0)
                {
                    numericUpDown1.BackColor = Color.Red;
                    e.Cancel = true;
                }
                else
                    Amount = numericUpDown1.Value;
            }
        }

        private void ChooseItem_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ItemsGridVieww.RowCount; i++)
            {
                if ((decimal) ItemsGridVieww.Rows[i].Cells[2].Value < 500)
                {
                    ItemsGridVieww.Rows[i].Cells[0].Style.BackColor = Color.RosyBrown;
                }
                else if ((decimal) ItemsGridVieww.Rows[i].Cells[2].Value < 1000)
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
