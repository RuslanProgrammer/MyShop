using System.Collections.Generic;

namespace MyShop
{
    public class Item
    {
        public Item(string name, string unit, decimal price, double available)
        {
            Id = _total++;
            Name = name;
            Unit = unit;
            Price.Add(price);
            Available = available;
        }
        
        private static int _total = 0;
        public int Id { set; get; }
        public string Name { set; get; }
        public string Unit { set; get; }
        public List<decimal> Price = new List<decimal>();
        public double Sold = 0;
        private double _available;

        public double Available
        {
            set => _available = value;
            get => _available - Sold;
        }
    }
}