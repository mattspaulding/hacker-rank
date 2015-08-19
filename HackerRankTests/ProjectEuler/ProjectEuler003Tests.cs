using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.ProjectEuler;
using HackerRankTests;
using System.Reflection;

namespace HackerRank.Tests.ProjectEuler
{
    [TestClass]
    public class ProjectEuler003Tests
    {
        [TestMethod]
        public void ProjectEuler003Test00()
        {
            Utils.CompareOutputs(new ProjectEuler003().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
    }
}
