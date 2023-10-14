using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskykhVA.Sprint2.Task5.V5.Lib;

namespace Tyuiu.KosovskykhVA.Sprint2.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            Assert.AreEqual("Туз", service1.FindCardValue(14));
        }
    }
}
