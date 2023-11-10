using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyanzinaMA.Sprint4.Task4.V27.Lib;

namespace Tyuiu.PyanzinaMA.Sprint4.Task4.V27.Test
{
    [TestClass]
    public class DataSeviceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] Array = new int[,] { { 1,5,3 }, { 6,2,8 }, { 7,4,2 } };

            Assert.AreEqual(16, ds.Calculate(Array));
        }
    }
}
