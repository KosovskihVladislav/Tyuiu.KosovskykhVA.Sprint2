using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskykhVA.Sprint2.Task7.V6.Lib;

namespace Tyuiu.KosovskykhVA.Sprint2.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(true, service1.CheckDotInShadedArea(1.2, 1.2));
        }
    }
}
