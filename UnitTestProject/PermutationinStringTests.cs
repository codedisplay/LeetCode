using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class PermutationinStringTests
    {
        [TestMethod]
        public void CheckInclusionTests()
        {
            PermutationinString obj = new PermutationinString();

            string S = "ab", T = "eidboaoo";
            var x = obj.CheckInclusion(S,T);//f

            S = "ab";
            T = "eidbaooo";
            x = obj.CheckInclusion(S, T);//t

        }
    }
}
