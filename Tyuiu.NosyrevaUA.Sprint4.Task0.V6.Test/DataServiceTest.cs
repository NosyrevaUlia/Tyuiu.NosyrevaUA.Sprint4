using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint4.Task0.V6.Lib;

namespace Tyuiu.NosyrevaUA.Sprint4.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
            int res = 32;
            Assert.AreEqual(ds.GetSumOddArrEl(numsArray), res);
        }
    }
}
