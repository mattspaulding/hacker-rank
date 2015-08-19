using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Algorithms.Warmup;
using HackerRankTests;
using System.Reflection;

namespace HackerRank.Tests.Algorithms.Warmup
{
    [TestClass]
    public class MaximizingXorTests
    {
        [TestMethod]
        public void MaximizingXorTest00()
        {
            Utils.CompareOutputs(new MaximizingXor().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
        [TestMethod]
        public void MaximizingXorTest11()
        {
            Utils.CompareOutputs(new MaximizingXor().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
    }
}
