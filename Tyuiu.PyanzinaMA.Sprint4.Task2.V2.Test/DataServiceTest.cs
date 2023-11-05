using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyanzinaMA.Sprint4.Task2.V2.Lib;

namespace Tyuiu.PyanzinaMA.Sprint4.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] array = { 1, 2, 3, 4 };
            Assert.AreEqual(3, ds.Calculate(array));
        }
    }
}
