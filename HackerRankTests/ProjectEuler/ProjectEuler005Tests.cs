using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.ProjectEuler;
using HackerRankTests;
using System.Reflection;

namespace HackerRank.Tests.ProjectEuler
{
    [TestClass]
    public class ProjectEuler005Tests
    {
        [TestMethod]
        public void ProjectEuler005Test00()
        {
            Utils.CompareOutputs(new ProjectEuler005().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
    }
}
