using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyShop;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Shop shop = new Shop();
            shop.FillTest(100);
            Assert.AreEqual("Product_0", shop.Items[0].Name);
            Assert.AreEqual("Product_8", shop.Items[8].Name);
            Assert.AreEqual(0, shop.Items[0].Id);
            Assert.AreEqual(8, shop.Items[8].Id);
            Assert.AreEqual("User_0", shop.Users[0].Name);
            Assert.AreEqual("User_8", shop.Users[8].Name);
            Assert.AreEqual("User_0", shop.Orders[0].User.Name);
            Assert.AreEqual("User_8", shop.Orders[8].User.Name);
            Assert.AreEqual("Product_0", shop.Orders[0].Portions[0].Item.Name);
            Assert.AreEqual(0, shop.Orders[0].Portions[0].Item.Id);
            Assert.AreEqual("Product_9", shop.Orders[0].Portions[9].Item.Name);
            Assert.AreEqual(9, shop.Orders[0].Portions[9].Item.Id);
            Assert.AreEqual("Product_8", shop.Orders[8].Portions[0].Item.Name);
            Assert.AreEqual(8, shop.Orders[0].Portions[8].Item.Id);
            Assert.AreEqual("Product_17", shop.Orders[8].Portions[9].Item.Name);
            Assert.AreEqual(17, shop.Orders[8].Portions[9].Item.Id);
        }
    }
}
