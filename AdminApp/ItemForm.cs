using System;
using System.Collections.Generic;
using System.Drawing;
using MyShop;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class ItemForm : Form
    {
        public Item Item;
        private List<Item> items;
        public ItemForm(List<Item> Items)
        {
            InitializeComponent();
            items = Items;
        }

        public ItemForm(Item item, List<Item> Items) : this(Items)
        {
            Item = item;
            NameTextBox.Text = item.Name;
            UnitComboBox.Text = item.Unit;
            PriceUpDown.Value = item.Price[item.Price.Count - 1];
            AvaliableUpDown.Value = item.Available;
            PictureBox.Image = item.Image;
        }

        private void PictureBox_DoubleClick(object sender, System.EventArgs e)
        {
            ChangeImageButton_Click(sender, e);
        }

        private void ChangeImageButton_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PictureBox.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            if (Item == null)
            {
                Item = new Item(NameTextBox.Text, UnitComboBox.Text, PriceUpDown.Value, AvaliableUpDown.Value, PictureBox.Image);
                foreach (var i in items)
                {
                    if (i.Name == Item.Name)
                    {
                        MessageBox.Show("Item already exist");
                        Mark(NameTextBox);
                        break;
                    }
                }
            }
            Item.Name = NameTextBox.Text;
            Item.Unit = UnitComboBox.Text;
            Item.Price.Add(PriceUpDown.Value);
            Item.Available = AvaliableUpDown.Value;
            Item.Image = PictureBox.Image;
        }

        private void NameTextBox_TextChanged(object sender, System.EventArgs e) => NameTextBox.BackColor = Color.White;


        private void PriceUpDown_ValueChanged(object sender, System.EventArgs e) => PriceUpDown.BackColor = Color.White;

        private void UnitComboBox_SelectedIndexChanged(object sender, System.EventArgs e) => UnitComboBox.BackColor = Color.White;

        private void AvaliableUpDown_ValueChanged(object sender, EventArgs e) => AvaliableUpDown.BackColor = Color.White;

        private void ItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                bool flag = false;
                int i;
                if (NameTextBox.Text.Length <= 1 || NameTextBox.Text.Length > 30 || Int32.TryParse(NameTextBox.Text, out i) || NameTextBox.BackColor == Color.Red)
                {
                    Mark(NameTextBox);
                    flag = true;
                }

                if(PriceUpDown.Value == 0)
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

                if(flag)
                    e.Cancel = true;
            }
        }

        private void Mark(Control c) => c.BackColor = Color.Red;

        
    }
}
