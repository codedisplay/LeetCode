using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ShuffleStringTests
    {
        [TestMethod]
        public void RestoreStringTests()
        {
            ShuffleString obj = new ShuffleString();

            string s = "codeleet";
            int[] indices = { 4, 5, 6, 7, 0, 2, 1, 3 };
            var x = obj.RestoreString(s, indices);//leetcode

            s = "abc";
            indices = new int[] { 0, 1, 2 };
            x = obj.RestoreString(s, indices);//abc
        }
    }
}
