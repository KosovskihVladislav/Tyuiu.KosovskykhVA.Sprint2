using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskykhVA.Sprint2.Task0.V25.Lib;

namespace Tyuiu.KosovskykhVA.Sprint2.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService service1 = new DataService();
            bool[] res = new bool[6] { false, true, false, true, false, true };
            CollectionAssert.AreEqual(res, service1.GetCompareOperations(205, 159));
        }
    }
}
