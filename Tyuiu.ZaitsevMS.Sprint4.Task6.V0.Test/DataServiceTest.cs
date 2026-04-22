using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint4.Task6.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint4.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var week = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            int res = ds.Calculate(week);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
