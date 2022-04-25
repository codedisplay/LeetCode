using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class BackspaceStringCompareTests
    {
        [TestMethod]
        public void GetAllElementsTests()
        {
            BackspaceStringCompare obj = new BackspaceStringCompare();

            string S = "ab#c", T = "ad#c";
            var isSame = obj.BackspaceCompare(S, T);
            Assert.AreEqual(isSame, true);

            S = "ab##";
            T = "c#d#";
            isSame = obj.BackspaceCompare(S, T);
            Assert.AreEqual(isSame, true);

            S = "a##c";
            T = "#a#c";
            isSame = obj.BackspaceCompare(S, T);
            Assert.AreEqual(isSame, true);

            S = "a#c";
            T = "b";
            isSame = obj.BackspaceCompare(S, T);
            Assert.AreEqual(isSame, false);

            S = "y#fo##f";
            T = "y#f#o##f";
            isSame = obj.BackspaceCompare(S, T);
            Assert.AreEqual(isSame, false);
        }

    }
}
