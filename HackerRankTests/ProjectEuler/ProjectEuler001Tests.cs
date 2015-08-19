using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.ProjectEuler;
using HackerRankTests;
using System.Reflection;

namespace HackerRank.Tests.ProjectEuler
{
    [TestClass]
    public class ProjectEuler001Tests
    {
        [TestMethod]
        public void ProjectEuler001Test00()
        {
            Utils.CompareOutputs(new ProjectEuler001().Main(Utils.ReadInput(MethodInfo.GetCurrentMethod().Name)), MethodInfo.GetCurrentMethod().Name);
        }
    }
}
