using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint4.Task7.V26.Lib;

namespace Tyuiu.ZaitsevMS.Sprint4.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate() 
        {
            DataService ds = new DataService();

            int rows = 5;
            int columns = 3;
            string str = "351268459614723";

            int res = ds.Calculate(rows, columns, str);

            int wait = 18432;
            Assert.AreEqual(wait, res);
        }
    }
}