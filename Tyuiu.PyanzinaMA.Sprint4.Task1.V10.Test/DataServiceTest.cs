using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyanzinaMA.Sprint4.Task1.V10.Lib;

namespace Tyuiu.PyanzinaMA.Sprint4.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] array = { 1, 2, 3, 4 };
            int wait = 3;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
