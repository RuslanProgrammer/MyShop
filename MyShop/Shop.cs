using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
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
            HistorySupplies = new List<Supply>();
        }

        public List<Item> Items { private set; get; }
        public List<User> Users { private set; get; }
        public List<Supply> Supplies { private set; get; }
        public List<Supply> HistorySupplies { private set; get; }

        public Admin Admin = new Admin()
        {
            Name = "admin",
            Password = "admin"
        };

        public void FillTest(int n)
        {
            n = Math.Min(n, 100);
            Items.Clear();
            Users.Clear();
            Supplies.Clear();
            var defImg = new Bitmap(Path.GetFullPath("item.png"));
            for (int i = 0; i < n; i++)
            {
                Items.Add(new Item($"Product_{i}", ((Unit)(i % 2)).ToString(), i + 1, 10000, defImg));
                Users.Add(new User($"User_{i}", "1234"));
            }

            for (int i = 0; i < n; i++)
            {
                var k = new List<Portion>(10);
                for (int j = 0; j < 10; j++)
                {
                    k.Add(new Portion {Item = Items[(i + j) % n], Amount = 1 + (i + j) % 100});
                    Items[i % n].Sold += 1 + (i + j) % 100;
                }
                Users[i].History = k;
                Supplies.Add(new Supply(k, DateTime.Now - TimeSpan.FromDays(n - i)));
            }
            Supplies.Reverse();
            UpdateSupplies();
        }

        public void AddUser(User user) => Users.Add(user);

        public void AddItem(Item item) => Items.Add(item);

        public void AddSupply(Supply supply) => Supplies.Add(supply);

        public void AddSupplyFirst(Supply supply) => Supplies.Insert(0, supply);

        public void UpdateSupplies()
        {
            for (int i = 0; i < Supplies.Count; i++)
            {
                if (Supplies[i].DateTimeEnd <= DateTime.Now)
                {
                    HistorySupplies.Add(CopySupply(Supplies[i]));
                    foreach (var portion in Supplies[i].Portions)
                    {
                        portion.Item.Available += portion.Amount;
                    }
                    Supplies.RemoveAt(i);
                    i--;
                }
            }
        }

        public void Save() => 
            new Dao(this).Save();

        public void Load()
        {
            new Dao(this).Load();
            UpdateSupplies();
        }

        private Supply CopySupply(Supply supplies)
        {
            var portions = new List<Portion>();
            foreach (var portion in supplies.Portions)
            {
                Portion p = portion;
                p.Item.Price = new List<decimal>() { portion.Item.Price[portion.Item.Price.Count - 1] };
                portions.Add(p);
            }
            return new Supply(portions, supplies.DateTime);
        }
    }
}