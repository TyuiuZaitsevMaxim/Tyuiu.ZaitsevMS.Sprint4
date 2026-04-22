using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint4.Task4.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint4.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[3, 3] { { 0, 0, 1 }, { 1, 0, 1 }, { 1, 1, 0 } };
            int res = ds.Calculate(mas2);
            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}
