using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint4.Task6.V9.Lib;

namespace Tyuiu.ZaitsevMS.Sprint4.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    { 
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            var colors = new string[] { "Красный", "Оранжевый", "Желтый", "Зеленый", "Синий", "Индиго", "Фиолетовый" };

            int res = ds.Calculate(colors);

            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}