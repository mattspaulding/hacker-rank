using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRankTests;
using HackerRank.Algorithms.Strings;
using System.Reflection;

namespace HackerRank.Tests.Algorithms.Strings
{
    [TestClass]
    public class PangramsTests
    {
        [TestMethod]
        public void PangramsTest00()
        {
            Utils.CompareOutputs(new Pangrams().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
        [TestMethod]
        public void PangramsTest01()
        {
            Utils.CompareOutputs(new Pangrams().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
    }
}
