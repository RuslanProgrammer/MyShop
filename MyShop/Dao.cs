using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyShop
{
    public class Dao
    {
        private Shop shop;
        private const string path = "shop.bin";

        public Dao(Shop _shop)
        {
            shop = _shop;
        }

        public void Save()
        {
            using (Stream stream = File.Create(path))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, shop);
            }
        }

        public void Load()
        {
            using (Stream stream = File.OpenRead(path))
            {
                var serializer = new BinaryFormatter();
                Shop st = (Shop)serializer.Deserialize(stream);

                Copy(st.Items, shop.Items);
                Copy(st.Users, shop.Users);
                Copy(st.Supplies, shop.Supplies);
                Copy(st.HistorySupplies, shop.HistorySupplies);
            }

            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }
    }
}