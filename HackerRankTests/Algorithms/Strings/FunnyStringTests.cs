using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRankTests;
using HackerRank.Algorithms.Strings;
using System.Reflection;

namespace HackerRank.Tests.Algorithms.Strings
{
    [TestClass]
    public class FunnyStringTests
    {
        [TestMethod]
        public void FunnyStringTest00()
        {
            Utils.CompareOutputs(new FunnyString().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
        [TestMethod]
        public void FunnyStringTest01()
        {
            Utils.CompareOutputs(new FunnyString().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
    }
}
