using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Algorithms.Warmup;
using HackerRankTests;
using System.Reflection;

namespace HackerRank.Tests.Algorithms.Warmup
{
    [TestClass]
    public class UtopianTreeTests
    {
        [TestMethod]
        public void UtopianTreeTest00()
        {
            Utils.CompareOutputs(new UtopianTree().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
        [TestMethod]
        public void UtopianTreeTest01()
        {
            Utils.CompareOutputs(new UtopianTree().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
    }
}
