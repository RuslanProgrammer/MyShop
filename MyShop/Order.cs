using System;
using System.Collections.Generic;

namespace MyShop
{
    [Serializable]
    public class Order
    {
        public Order(List<Portion> portions, User user, DateTime? t = null)
        {
            Portions = portions;
            foreach (var i in Portions)
                i.Item.Sold += i.Amount;
            User = user;
            if (t == null)
                DateTime = DateTime.Now;
            else
                DateTime = (DateTime) t;
        }

        public List<Portion> Portions { private set; get; }
        public User User { private set; get; }
        public DateTime DateTime { private set; get; }

    }
}