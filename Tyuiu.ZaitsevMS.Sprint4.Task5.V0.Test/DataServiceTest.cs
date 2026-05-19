using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint4.Task5.V26.Lib;

namespace Tyuiu.ZaitsevMS.Sprint4.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[5, 5]
            {
                {  3, -2,  4, -1,  2 },
                { -3,  1, -4,  0,  4 },
                {  2, -1,  3, -2,  1 },
                { -4,  4, -3,  2, -1 },
                {  1,  0, -2,  3, -4 }
            };

            int[,] wait = new int[5, 5]
            {
                {  1, -2,  1, -1,  1 },
                { -3,  1, -4,  0,  1 },
                {  1, -1,  1, -2,  1 },
                { -4,  1, -3,  1, -1 },
                {  1,  0, -2,  1, -4 }
            };

            int[,] res = ds.Calculate(mtrx);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}