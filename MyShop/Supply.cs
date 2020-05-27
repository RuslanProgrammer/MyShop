using System;
using System.Collections.Generic;

namespace MyShop
{
    // Supply: Portion + Order Time + Lead Time.
    [Serializable]
    public class Supply
    {
        public Supply(List<Portion> portions, DateTime? t = null)
        {
            Portions = portions;
            DateTime = t ?? DateTime.Now;
        }

        public List<Portion> Portions { private set; get; }
        public DateTime DateTime { set; get; }
        public DateTime DateTimeEnd => DateTime + TimeSpan.FromDays(2);
    }
}