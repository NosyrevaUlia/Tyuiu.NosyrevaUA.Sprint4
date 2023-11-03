using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint4.Task1.V27.Lib;

namespace Tyuiu.NosyrevaUA.Sprint4.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 8, 1, 4, 4, 1, 2, 3, 5, 1, 5 };
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(res, 256);
        }
    }
}
