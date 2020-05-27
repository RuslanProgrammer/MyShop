using System;

namespace MyShop
{
    // Portion: Amount + Item.
    [Serializable]
    public class Portion
    {
        public decimal Amount { set; get; }
        public Item Item { set; get; }
    }
}