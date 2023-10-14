using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskykhVA.Sprint2.Task2.V20.Lib;

namespace Tyuiu.KosovskykhVA.Sprint2.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(true, service1.CheckDotInShadedArea(3, 3));
        }
    }
}
