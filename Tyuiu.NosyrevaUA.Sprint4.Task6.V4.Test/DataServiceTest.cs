using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint4.Task6.V4.Lib;

namespace Tyuiu.NosyrevaUA.Sprint4.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] first = { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" }; 
            string[] res = ds.Calculate(first);
            string[] w = { "Москва", "Самара" };
            CollectionAssert.AreEqual(res, w);
        }
    }
}
