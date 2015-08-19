using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Challenges._101HackApril15;
using System.Reflection;

namespace HackerRankTests.Challenges._101HackApril15
{
    [TestClass]
    public class RatRaceTests
    {
        [TestMethod]
        public void RatRaceTest00()
        {
            Utils.CompareOutputs(new RatRace().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
    }
}
