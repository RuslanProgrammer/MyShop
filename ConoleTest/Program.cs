using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop;

namespace ConoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.FillTest(100);
        }
    }
}
