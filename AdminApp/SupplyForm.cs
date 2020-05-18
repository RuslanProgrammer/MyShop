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
    public partial class SupplyForm : Form
    {
        public Supply Supply;
        private List<Item> lst;
        public SupplyForm(List<Item> _lst)
        {
            InitializeComponent();
            lst = _lst;
            Supply = new Supply(new List<Portion>(), DateTime.Now);
            Deletebutton.Enabled = false;
            SaveButton.Enabled = false;

            var t = new DataGridViewImageColumn();
            t.ImageLayout = DataGridViewImageCellLayout.Zoom;
            SupplyTable.Columns.Add(t);
            SupplyTable.Columns[0].HeaderText = "Img";
            SupplyTable.Columns.Add("Name", "Name");
            SupplyTable.Columns.Add("Amount", "Amnt");
            SupplyTable.Columns.Add("Price", "Price");
            SupplyTable.Columns.Add("Cost", "Cost");
            SupplyTable.Columns[0].Width = 40;
            SupplyTable.Columns[1].Width = 75;
            SupplyTable.Columns[2].Width = 50;
            SupplyTable.Columns[3].Width = 55;
            SupplyTable.Columns[4].Width = 48;
        }

        public SupplyForm(Supply supply, List<Item> lst) : this(lst)
        {
            Supply = supply;
            AddRow(supply);

            Deletebutton.Enabled = true;
            SaveButton.Enabled = true;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            var cf = new ChooseItem(lst, Supply);
            if (cf.ShowDialog() == DialogResult.OK)
            {
                bool flag = true;
                foreach (var supplyPortion in Supply.Portions)
                {
                    if (supplyPortion.Item == cf.item)
                    {
                        supplyPortion.Amount += cf.amount;
                        flag = false;
                        for (int i = 0; i < SupplyTable.RowCount; i++)
                        {
                            if (SupplyTable.Rows[i].Cells[1].Value.ToString() == cf.item.Name)
                            {
                                SupplyTable.Rows[i].Cells[2].Value =
                                    (decimal) SupplyTable.Rows[i].Cells[2].Value + cf.amount;
                                SupplyTable.Rows[i].Cells[4].Value =
                                    (decimal) SupplyTable.Rows[i].Cells[4].Value +
                                    cf.amount * cf.item.Price[cf.item.Price.Count - 1];
                                break;
                            }
                        }
                        break;
                    }
                }

                if (flag)
                {
                    Supply.Portions.Add(new Portion() {Amount = cf.amount, Item = cf.item});
                    var price = cf.item.Price[cf.item.Price.Count - 1];
                    decimal cost = cf.amount * price;
                    SupplyTable.Rows.Add(cf.item.Image, cf.item.Name, cf.amount, price, cost);
                    Deletebutton.Enabled = true;
                    SaveButton.Enabled = true;
                }

                TotalLabe.Text = Math.Round(Decimal.Parse(TotalLabe.Text) + cf.amount * cf.item.Price[cf.item.Price.Count - 1], 3).ToString();
            }
        }

        private void AddRow(Supply supply)
        {
            foreach (var portion in supply.Portions)
            {
                SupplyTable.Rows.Add(portion.Item.Image, portion.Item.Name, portion.Amount,
                    portion.Item.Price[portion.Item.Price.Count - 1],
                    portion.Item.Price[portion.Item.Price.Count - 1] * portion.Amount);
                TotalLabe.Text = Math.Round(Decimal.Parse(TotalLabe.Text) + portion.Item.Price[portion.Item.Price.Count - 1] * portion.Amount, 3).ToString();
            }
        }

        private void SupplyForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            var ask = MessageBox.Show($"Delete {SupplyTable.CurrentRow.Cells[1].Value} ?", "", MessageBoxButtons.YesNo);
            if (ask == DialogResult.Yes)
            {

                TotalLabe.Text = Math.Round(Decimal.Parse(TotalLabe.Text) - (decimal)SupplyTable.SelectedRows[0].Cells[4].Value, 3).ToString();
                Supply.Portions.RemoveAt(SupplyTable.CurrentRow.Index);
                SupplyTable.Rows.RemoveAt(SupplyTable.CurrentRow.Index);
            }

            if (SupplyTable.SelectedRows.Count <= 0)
            {
                Deletebutton.Enabled = false;
                SaveButton.Enabled = false;
            }
        }
    }
}
