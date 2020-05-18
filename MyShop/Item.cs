using System;
using System.Collections.Generic;
using System.Drawing;

namespace MyShop
{
    [Serializable]
    public class Item
    {
        public Item(string name, string unit, decimal price, decimal available, Image image)
        {
            Id = _total++;
            Name = name;
            Unit = unit;
            Price.Add(price);
            Available = available;
            Image = image;
        }

        public static int _total = 0;
        public int Id { set; get; }
        public string Name { set; get; }
        public string Unit { set; get; }
        public Image Image { set; get; }
        public List<decimal> Price = new List<decimal>();
        public decimal Sold = 0;
        private decimal _available;

        public decimal Available
        {
            set => _available = value;
            get => _available - Sold;
        }
    }
}