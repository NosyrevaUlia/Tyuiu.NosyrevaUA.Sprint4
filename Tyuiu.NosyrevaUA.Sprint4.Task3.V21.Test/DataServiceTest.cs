using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint4.Task3.V21.Lib;

namespace Tyuiu.NosyrevaUA.Sprint4.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas = new int[5, 5] { { 8, 3, 3, 3, 5 }, { 6, 7, 3, 3, 7 }, { 4, 5, 4, 6, 6 }, { 5, 5, 8, 8, 7 }, { 4, 6, 6, 7, 7 } };
            int res = ds.Calculate(mas);
            Assert.AreEqual(res, 10290);
        }
    }
}
