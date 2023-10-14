using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskykhVA.Sprint2.Task3.V12.Lib;

namespace Tyuiu.KosovskykhVA.Sprint2.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(11, service1.Calculate(3));
        }
    }
}
