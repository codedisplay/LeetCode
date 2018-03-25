using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject
{
    [TestClass]
    public class OutputContestMatchesTests
    {
        [TestMethod]
        public void FindContestMatchTest()
        {
            OutputContestMatches l = new OutputContestMatches();

           Assert.AreEqual("(1,2)", l.FindContestMatch(2));
            Assert.AreEqual("((1,4),(2,3))", l.FindContestMatch(4));
            Assert.AreEqual("(((1,8),(4,5)),((2,7),(3,6)))", l.FindContestMatch(8));
        }
    }
}
