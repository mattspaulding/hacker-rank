using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.ProjectEuler;
using HackerRankTests;
using System.Reflection;

namespace HackerRank.Tests.ProjectEuler
{
    [TestClass]
    public class ProjectEuler004Tests
    {
        [TestMethod]
        public void ProjectEuler004Test00()
        {
            Utils.CompareOutputs(new ProjectEuler004().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
    }
}
