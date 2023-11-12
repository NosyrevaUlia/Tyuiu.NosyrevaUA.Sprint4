using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint4.Task7.V26.Lib;

namespace Tyuiu.NosyrevaUA.Sprint4.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int n = 5;
            int m = 3;
            int[,] mat = new int[n, m];
            string str = "351268459614723";
            int res = ds.Calculate(n, m, str);
            int w = 18432;
            Assert.AreEqual(res, w);
        }
    }
}
