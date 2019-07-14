using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        [TestMethod]
        public void LengthOfLongestSubstringTests()
        {
            LongestSubstringWithoutRepeatingCharacters obj = new LongestSubstringWithoutRepeatingCharacters();


            //var x =  obj.LengthOfLongestSubstring("abba");//2

            var x = obj.LengthOfLongestSubstring("abcabcbb");//3
            x = obj.LengthOfLongestSubstring("bbbbb");//1
            x = obj.LengthOfLongestSubstring("pwwkew");//3

            x = obj.LengthOfLongestSubstring(" ");//1

            x = obj.LengthOfLongestSubstring("aab");//2
            x = obj.LengthOfLongestSubstring("abba");//2
            x = obj.LengthOfLongestSubstring("tmmzuxt");//5
        }
    }
}