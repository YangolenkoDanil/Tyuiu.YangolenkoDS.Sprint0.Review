using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YangolenkoDS.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.YangolenkoDS.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int x = 50;
            int y = 10;
            int z = 5;
            int res = DataService.Calc(x, y, z);
            Assert.AreEqual(325, res);
        }
    }
}
