using MyShop;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class ItemForm : Form
    {
        public Item Item;
        private readonly List<Item> _items;

        public ItemForm(List<Item> items)
        {
            InitializeComponent();
            _items = items;
        }

        public ItemForm(Item item, List<Item> items, List<Supply> supplies) : this(items)
        {
            Item = item;
            NameTextBox.Text = item.Name;
            NameTextBox.Enabled = false;
            UnitComboBox.Text = item.Unit;
            PriceUpDown.Value = item.Price[item.Price.Count - 1];
            AvaliableUpDown.Value = item.Available;
            PictureBox.Image = item.Image;
            PriceUpDown.Enabled = supplies.Count(x => x.Portions.Any(y => y.Item.Name == item.Name)) == 0;
        }

        private void PictureBox_DoubleClick(object sender, System.EventArgs e) =>
            ChangeImageButton_Click(sender, e);

        private void ChangeImageButton_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                PictureBox.Image = new Bitmap(openFileDialog1.FileName);
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            if (Item == null)
            {
                Item = new Item(NameTextBox.Text,
                    UnitComboBox.Text,
                    PriceUpDown.Value,
                    AvaliableUpDown.Value,
                    PictureBox.Image);
                if (_items.Any(i => i.Name == Item.Name))
                {
                    MessageBox.Show("Item already exist");
                    Mark(NameTextBox);
                    Item = null;
                }
            }
            else
            {
                Item.Unit = UnitComboBox.Text;
                if(Item.Price[Item.Price.Count - 1] != PriceUpDown.Value)
                    Item.Price.Add(PriceUpDown.Value);
                Item.Available = AvaliableUpDown.Value;
                Item.Image = PictureBox.Image;
            }
        }

        private void NameTextBox_TextChanged(object sender, System.EventArgs e) =>
            NameTextBox.BackColor = Color.White;

        private void PriceUpDown_ValueChanged(object sender, System.EventArgs e) =>
            PriceUpDown.BackColor = Color.White;

        private void UnitComboBox_SelectedIndexChanged(object sender, System.EventArgs e) =>
            UnitComboBox.BackColor = Color.White;

        private void AvailableUpDown_ValueChanged(object sender, EventArgs e) =>
            AvaliableUpDown.BackColor = Color.White;

        private void ItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                bool flag = false;
                if (NameTextBox.Text.Length <= 1 || NameTextBox.Text.Length > 30 || Int32.TryParse(NameTextBox.Text, out _) || NameTextBox.BackColor == Color.Red)
                {
                    Mark(NameTextBox);
                    flag = true;
                }

                if (PriceUpDown.Value == 0)
                {
                    Mark(PriceUpDown);
                    flag = true;
                }

                if (AvaliableUpDown.Value != (int)AvaliableUpDown.Value && UnitComboBox.Text == "unit")
                {
                    Mark(AvaliableUpDown);
                    flag = true;
                }

                if (UnitComboBox.Text != "unit" && UnitComboBox.Text != "l" && UnitComboBox.Text != "kg")
                {
                    Mark(UnitComboBox);
                    flag = true;
                }

                if (flag)
                    e.Cancel = true;
            }
        }

        private void Mark(Control c) =>
            c.BackColor = Color.Red;

        private void button1_Click(object sender, EventArgs e)
        {
            if (Item != null) new ChartP(Item.Price).ShowDialog();
        }
    }
}