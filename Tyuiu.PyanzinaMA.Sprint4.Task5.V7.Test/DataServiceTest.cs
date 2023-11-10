using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyanzinaMA.Sprint4.Task5.V7.Lib;

namespace Tyuiu.PyanzinaMA.Sprint4.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] testArray = new int[,] { { -2,6,-3,5 }, { -1,0,2,3 }, { 4,-5,3,-4 } };

            Assert.AreEqual(5, ds.Calculate(testArray));
        }
    }
}
