using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [Test]
        public void PizzaName()
        {
            var pizza = new Class1 { Id = 1, Name = "VegLoaded", Price = 2500, quantity=1 };
            var res = pizza.GetName();
            Assert.AreEqual("Pizza:VegLoaded", res);
        }

        [Test]
        public void PizzaPrice()
        {
            var pizza = new Class1 { Id = 1, Name = "VegLoaded", Price = 2500, quantity = 1 };
            var res = pizza.GetPrice();
            Assert.AreEqual("Pizza:2500", res);
        }
        [Test]
        public void PizzaQuantity()
        {
            var pizza = new Class1 { Id = 1, Name = "VegLoaded", Price = 2500 , quantity = 1 };
            var res = pizza.GetQuantity();
            Assert.GreaterOrEqual("Pizza:1", res);
        }
    }
}
