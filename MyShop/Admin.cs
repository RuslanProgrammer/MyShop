using System;

namespace MyShop
{
    // Admin: Name + Password.
    [Serializable]
    public class Admin
    {
        public string Name { set; get; }
        public string Password { set; get; }
    }
}