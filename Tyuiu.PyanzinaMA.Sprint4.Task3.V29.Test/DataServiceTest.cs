using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyanzinaMA.Sprint4.Task3.V29.Lib;

namespace Tyuiu.PyanzinaMA.Sprint4.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] x = { { 2, 1, 6 },
                          { 2, 4, 2 },
                          { 5, 3, 1} };
            Assert.AreEqual(20, ds.Calculate(x));
        }
    }
}
