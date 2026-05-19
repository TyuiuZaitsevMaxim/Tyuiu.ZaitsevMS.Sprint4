using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint4.Task2.V24.Lib;

namespace Tyuiu.ZaitsevMS.Sprint4.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 5, 9, 4, 6, 5, 4, 4, 7, 8, 9, 5, 9 };

            int res = ds.Calculate(numsArray);

            int wait = 49;
            Assert.AreEqual(wait, res);
        }
    }
}