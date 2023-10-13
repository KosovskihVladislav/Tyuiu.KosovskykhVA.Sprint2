using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskykhVA.Sprint2.Task1.V9.Lib;

namespace Tyuiu.KosovskykhVA.Sprint2.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService service1 = new DataService();
            bool[] res = new bool[6] { true, false, true, false, false, true };
            CollectionAssert.AreEqual(res, service1.GetLogicOperations(15, 335, 174, 478));
        }
    }
}
