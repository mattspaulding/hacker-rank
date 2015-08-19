using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRankTests;
using HackerRank.Algorithms.Strings;
using System.Reflection;

namespace HackerRank.Tests.Algorithms.Strings
{
    [TestClass]
    public class HammingDistanceTests
    {
        [TestMethod]
        public void HammingDistanceTest00()
        {
            Utils.CompareOutputs(new HammingDistance().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
        [TestMethod]
        public void HammingDistanceTest11()
        {
            Utils.CompareOutputs(new HammingDistance().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
        [TestMethod]
        public void HammingDistanceTest25()
        {
            Utils.CompareOutputs(new HammingDistance().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
    }
}
