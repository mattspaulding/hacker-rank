using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Challenges._101HackApril15;
using System.Reflection;

namespace HackerRankTests.Challenges._101HackApril15
{
    [TestClass]
    public class TwistyTupleTests
    {
        [TestMethod]
        public void TwistyTupleTest00()
        {
            Utils.CompareOutputs(new TwistyTuple().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
        [TestMethod]
        public void TwistyTupleTest01()
        {
            Utils.CompareOutputs(new TwistyTuple().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
    }
}
