using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CoffeeSystem;

namespace Amounttest
{
    [TestClass]
    public class UnitTest1
    {
        Coffeeshop cshop;
        [TestInitialize]
        public void Setup()
        {
            cshop=new Coffeeshop();
            cshop.Setsandwitchprice(50);
            cshop.Setcoffeeprice(500);
        }

        [DataTestMethod]
        [DataRow(true,false,500)]
        [DataRow(true,true,550)]
        [DataRow(false,false,0)]
        [DataRow(false,true,50)]
        public void TestMethod1(bool a,bool b,double expected)
        {
            double response = cshop.AmountCalculation(a, b);
            Assert.AreEqual(expected, response);
        }
    }
}
