using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint6.TaskReview.V17.Lib;

namespace Tyuiu.VolodinaAA.Sprint6.TaskReview.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            int n1 = -5;
            int n2 = 5;
            int n = 3;
            int m = 4;
            int c = 2;
            int k = 2;
            int l = 2;
            int[,] array = new int[3, 4] { { -5, 4, 1, 5},
                                           { 2, 0, -1, 3},
                                           { -1, -3, 5, 2} };
            int result = ds.GetMatrix(array, n1, n2, c, k, l);
            int wait = 5;
            Assert.AreEqual(wait, result);
        }
    }
}
