using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaevaAN.Sprint4.TaskReview.V12.Lib;

namespace Tyuiu.NikolaevaAN.Sprint4.TaskReview.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int rows = 3;
            int columns = 4;
            int[,] mtrx = new int[rows, columns];
            string str = "658932125478";
            int res = ds.Calculate(rows, columns, str);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}
