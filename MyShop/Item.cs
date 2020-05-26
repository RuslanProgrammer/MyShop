using System;
using System.Collections.Generic;
using System.Drawing;

namespace MyShop
{
    [Serializable]
    public class Item
    {
        public decimal Sold = 0;
        private decimal _available;

        public Item(string name, string unit, decimal price, decimal available, Image image)
        {
            Name = name;
            Unit = unit;
            Price = new List<decimal>(){price};
            Available = available;
            Image = image;
        }

        public string Name { set; get; }
        public string Unit { set; get; }
        public Image Image { set; get; }
        public List<decimal> Price { set; get; }
        public decimal Available
        {
            set => _available = value;
            get => _available - Sold;
        }
    }
}