using System.Collections.Generic;

namespace MyShop
{
    public class User : IAccount
    {
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public string Name { set; get; }
        public string Password { set; get; }
        public List<Portion> History = new List<Portion>();
    }
}