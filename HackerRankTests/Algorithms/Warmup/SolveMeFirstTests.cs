using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Algorithms.Warmup;
using HackerRankTests;
using System.Reflection;

namespace HackerRank.Tests.Algorithms.Warmup
{
    [TestClass]
    public class SolveMeFirstTests
    {
        [TestMethod]
        public void SolveMeFirstTest00()
        {
            Utils.CompareOutputs(new SolveMeFirst().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
    }
}
