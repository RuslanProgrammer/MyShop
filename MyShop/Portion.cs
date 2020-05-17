using System;

namespace MyShop
{
    [Serializable]
    public class Portion
    {
        public decimal Amount { set; get; }
        public Item Item { set; get; }
    }
}