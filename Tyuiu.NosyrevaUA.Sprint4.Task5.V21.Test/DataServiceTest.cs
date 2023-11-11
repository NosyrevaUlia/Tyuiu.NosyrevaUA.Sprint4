using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint4.Task5.V21.Lib;

namespace Tyuiu.NosyrevaUA.Sprint4.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas1 = { { 1, 0, 8, -2, 1 }, { 9, -9, 9, 9, 9 }, { 9, 9, 9, 9, 9 }, { -9, -9, -9, -9, -9 }, { -9, 9, -9, -9, 9 } };
            int[,] res = { { 1, 0, 1, -2, 1 }, { 1, -9, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { -9, -9, -9, -9, -9 }, { -9, 1, -9, -9, 1 } };
            CollectionAssert.AreEqual(res, ds.Calculate(mas1));
        }
    }
}
