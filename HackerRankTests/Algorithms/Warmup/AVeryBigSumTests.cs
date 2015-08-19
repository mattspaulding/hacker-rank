using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Algorithms.Warmup;
using HackerRankTests;
using System.Reflection;

namespace HackerRank.Tests.Algorithms.Warmup
{
    [TestClass]
    public class AVeryBigSumTests
    {
        [TestMethod]
        public void AVeryBigSumTest00()
        {
            Utils.CompareOutputs(new AVeryBigSum().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
    }
}
