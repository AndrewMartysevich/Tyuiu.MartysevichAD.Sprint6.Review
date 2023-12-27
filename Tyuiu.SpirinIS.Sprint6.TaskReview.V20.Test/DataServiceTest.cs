using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint6.TaskReview.V20.Lib;

namespace Tyuiu.MartysevichAD.Sprint6.TaskReview.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            int N = 4;
            int M = 4;
            int n1 = 2;
            int n2 = 3;
            int r = 0;
            int k = 0;
            int l = 3;
            int[,] arr = new int[N,M];
            int res = ds.GetMatrix(arr, n1, n2, r, k, l);
            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}
