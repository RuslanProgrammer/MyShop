using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace MyShop
{
    [Serializable]
    public class Shop
    {
        public Shop()
        {
            Items = new List<Item>();
            Users = new List<User>();
            Supplies = new List<Supply>();
            Orders = new List<Order>();
        }

        public List<Item> Items { private set; get; }
        public List<User> Users { private set; get; }
        public List<Supply> Supplies { private set; get; }
        public List<Order> Orders { private set; get; }
        public Admin admin = new Admin()
        {
            Name = "admin", 
            Password = "admin"
        };

        public void FillTest(int n)
        {
            Items.Clear();
            Users.Clear();
            Orders.Clear();
            var defImg = new Bitmap(Path.GetFullPath("item.png"));
            for (int i = 0; i < n; i++)
            {
                Items.Add(new Item($"Product_{i}", ((Unit)(i%2)).ToString(), i + 1, (decimal)Math.Round(Math.Pow(n + i, 1.6), 3), defImg));
                Users.Add(new User($"User_{i}", "1234"));
            }

            for (int i = 0; i < n; i++)
            {
                var k = new List<Portion>(10);
                for (int j = 0; j < 10; j++)
                    k.Add(new Portion {Item = Items[i % n], Amount = 1 + (i * j)});
                Orders.Add(new Order(k, Users[i], DateTime.Now - TimeSpan.FromDays(n - i)));
                Users[i].History.AddRange(k);
            }
        }

        public void AddUser(User user) => Users.Add(user);

        public void AddItem(Item item) => Items.Add(item);

        public void Save()
        {
            new Dao(this).Save();
        }

        public void Load()
        {
            new Dao(this).Load();
        }
    }
}