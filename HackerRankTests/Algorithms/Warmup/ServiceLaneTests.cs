using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Algorithms.Warmup;
using HackerRankTests;
using System.Reflection;

namespace HackerRank.Tests.Algorithms.Warmup
{
    [TestClass]
    public class ServiceLaneTests
    {
        [TestMethod]
        public void ServiceLaneTest00()
        {
            Utils.CompareOutputs(new ServiceLane().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
    }
}
