using System;
using System.Collections.Generic;

namespace MyShop
{
    public class Supply
    {
        public Supply(List<Portion> portions)
        {
            Portions = portions;
            DateTime = DateTime.Now;
        }

        public List<Portion> Portions { private set; get; }
        public DateTime DateTime { private set; get; }
    }
}