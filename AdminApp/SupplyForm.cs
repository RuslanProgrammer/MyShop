using MyShop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class SupplyForm : Form
    {
        public Supply Supply;
        private readonly List<Item> _lst;

        public SupplyForm(List<Item> lst)
        {
            InitializeComponent();
            _lst = lst;
            Supply = new Supply(new List<Portion>(), DateTime.Now);
            Deletebutton.Enabled = false;
            SaveButton.Enabled = false;
            CheckAuto();
            CreateSupplyTable();
        }
        public SupplyForm(Supply supply, List<Item> lst) : this(lst)
        {
            Supply = supply;
            AddRow(supply);
            Deletebutton.Enabled = true;
            SaveButton.Enabled = true;
            AutoButton.Enabled = false;
        }
        public SupplyForm(Supply supply)
        {
            InitializeComponent();
            Supply = supply;
            CreateSupplyTable();
            AddRow(supply);
            NewButton.Enabled = false;
            Deletebutton.Enabled = false;
            SaveButton.Enabled = false;
            AutoButton.Enabled = false;
        }

        private void CheckAuto()
        {
            if (_lst.Select(x => x.Available < 500).Count(x => x) == 0)
                AutoButton.Enabled = false;
        }

        private void CreateSupplyTable()
        {
            var t = new DataGridViewImageColumn { ImageLayout = DataGridViewImageCellLayout.Zoom };
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
            SupplyTable.Columns[4].Width = 62;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            var cf = new ChooseItem(_lst, Supply);
            if (cf.ShowDialog() == DialogResult.OK)
            {
                bool flag = true;
                foreach (var supplyPortion in Supply.Portions)
                {
                    if (supplyPortion.Item == cf.Item)
                    {
                        supplyPortion.Amount += cf.Amount;
                        flag = false;
                        for (int i = 0; i < SupplyTable.RowCount; i++)
                        {
                            if (SupplyTable.Rows[i].Cells[1].Value.ToString() == cf.Item.Name)
                            {
                                SupplyTable.Rows[i].Cells[2].Value =
                                    (decimal)SupplyTable.Rows[i].Cells[2].Value + cf.Amount;
                                SupplyTable.Rows[i].Cells[4].Value =
                                    (decimal)SupplyTable.Rows[i].Cells[4].Value +
                                    cf.Amount * cf.Item.Price[cf.Item.Price.Count - 1];
                                break;
                            }
                        }
                        break;
                    }
                }

                if (flag)
                {
                    Supply.Portions.Add(new Portion() { Amount = cf.Amount, Item = cf.Item });
                    var price = cf.Item.Price[cf.Item.Price.Count - 1];
                    decimal cost = cf.Amount * price;
                    SupplyTable.Rows.Add(cf.Item.Image, cf.Item.Name, cf.Amount, price, cost);
                    Deletebutton.Enabled = true;
                    SaveButton.Enabled = true;
                    AutoButton.Enabled = false;
                }

                TotalLabe.Text = Math.Round(Decimal.Parse(TotalLabe.Text) + cf.Amount * cf.Item.Price[cf.Item.Price.Count - 1], 3).ToString();
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

        private void DeleteButton_Click(object sender, EventArgs e)
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
                CheckAuto();
            }
        }

        private void AutoButton_Click(object sender, EventArgs e)
        {
            foreach (var item in _lst)
            {
                if (item.Available < 500)
                {
                    Supply.Portions.Add(new Portion() { Amount = 500 - item.Available, Item = item });
                    SupplyTable.Rows.Add(item.Image, item.Name, 500 - item.Available, item.Price[item.Price.Count - 1], item.Price[item.Price.Count - 1] * 500 - item.Available);
                    TotalLabe.Text = Math.Round(Decimal.Parse(TotalLabe.Text) + (500 - item.Available) * item.Price[item.Price.Count - 1], 3).ToString();
                }
            }
            Deletebutton.Enabled = true;
            SaveButton.Enabled = true;
            AutoButton.Enabled = false;
        }
    }
}
