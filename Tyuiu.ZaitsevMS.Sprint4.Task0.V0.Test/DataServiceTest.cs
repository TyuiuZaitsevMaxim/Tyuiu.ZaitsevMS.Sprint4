using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint4.Task0.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint4.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 0, 3, 0, 10 };
            int[] res = ds.Calculate(numsArray);
            int[] numWaitArray = { 4, 1, 3, 1, 10 };
            CollectionAssert.AreEqual(numWaitArray, res);
        }
    }
}
