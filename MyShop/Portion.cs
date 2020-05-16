using System;

namespace MyShop
{
    [Serializable]
    public class Portion
    {
        public double Amount { set; get; }
        public Item Item { set; get; }
    }
}