using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.ProjectEuler;
using HackerRankTests;
using System.Reflection;

namespace HackerRank.Tests.ProjectEuler
{
    [TestClass]
    public class ProjectEuler002Tests
    {
        [TestMethod]
        public void ProjectEuler002Test00()
        {
            Utils.CompareOutputs(new ProjectEuler002().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
    }
}
