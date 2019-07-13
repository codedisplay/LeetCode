using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class Group_AnagramsTests
    {
        [TestMethod]
        public void MajorityElementTests()
        {
            Group_Anagrams obj = new Group_Anagrams();

            //Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
            //Output:
            //[
            //  ["ate", "eat", "tea"],
            //  ["nat","tan"],
            //  ["bat"]
            //]
            var arr = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var x = obj.GroupAnagrams(arr);

  
        }
    }
}