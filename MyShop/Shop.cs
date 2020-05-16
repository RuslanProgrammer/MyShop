using System;
using System.Collections.Generic;

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
            for (int i = 0; i < n; i++)
            {
                Items.Add(new Item($"Product_{i}", "kg", i + 1, (i + 1)%10 * 200));
                Users.Add(new User($"User_{i}", "1234"));
            }

            for (int i = 0; i < n; i++)
            {
                var k = new List<Portion>(10);
                for (int j = 0; j < 10; j++)
                    k.Add(new Portion {Item = Items[(i + j) % n], Amount = i%15 + j + 1 + i%(j+1)});
                Orders.Add(new Order(k, Users[i], DateTime.Now - TimeSpan.FromDays(n - i)));
                Users[i].History.AddRange(k);
            }
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }
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