using System;
using System.Collections.Generic;

namespace MyShop
{
    [Serializable]
    public class Supply
    {
        public Supply(List<Portion> portions, DateTime? t = null)
        {
            Portions = portions;
            if (t == null)
                DateTime = DateTime.Now;
            else
                DateTime = (DateTime)t;
        }
        public List<Portion> Portions { private set; get; }
        public DateTime DateTime { private set; get; }

        public DateTime DateTimeEnd => DateTime + TimeSpan.FromDays(2);
    }
}