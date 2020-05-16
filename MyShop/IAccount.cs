using System;

namespace MyShop
{
    public interface IAccount
    {
        string Name { set; get; }
        string Password { set; get; }
    }
}