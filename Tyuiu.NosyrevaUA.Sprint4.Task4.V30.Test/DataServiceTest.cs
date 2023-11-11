using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint4.Task4.V30.Lib;

namespace Tyuiu.NosyrevaUA.Sprint4.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas1 = new int[,] { { 3, 4, 6, 6, 5 }, { 6, 7, 6, 3, 5 }, { 5, 3, 5, 7, 6 }, { 6, 4, 7, 6, 6 }, { 7, 4, 3, 4, 5 } };
            int[,] res = ds.Calculate(mas1);

            int[,] w = { { 0, 4, 6, 6, 0 }, { 6, 0, 6, 0, 0 }, { 0, 0, 0, 0, 6 }, { 6, 4, 0, 6, 6 }, { 0, 4, 0, 4, 0 } };
            CollectionAssert.AreEqual(w, res);
        }
    }
}
