using System;
using System.Collections.Generic;

namespace MyShop
{
    // User: Name + Password + History + Basket.
    [Serializable]
    public class User
    {
        public User(string name, string password)
        {
            Name = name;
            Password = password;
            History = new List<Portion>();
            Basket = new List<Portion>();
        }

        public string Name { set; get; }
        public string Password { set; get; }
        public List<Portion> History { set; get; }
        public List<Portion> Basket { set; get; }
    }
}