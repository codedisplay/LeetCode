using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class LongestSubstringwithAtMostTwoDistinctCharactersTests
    {
        [TestMethod]
        public void NumKLenSubstrNoRepeatsTests()
        {
            LongestSubstringwithAtMostTwoDistinctCharacters obj = new LongestSubstringwithAtMostTwoDistinctCharacters();

            var S = "eceba";
            var x = obj.LengthOfLongestSubstringTwoDistinct(S);//3

            S = "ccaabbb";
            x = obj.LengthOfLongestSubstringTwoDistinct(S);//5

            S = "abaccc";
            x = obj.LengthOfLongestSubstringTwoDistinct(S);//4

            S = "cdaba";
            x = obj.LengthOfLongestSubstringTwoDistinct(S);//3

            S = "ababffzzeee";
            x = obj.LengthOfLongestSubstringTwoDistinct(S);//5

            S = "bbcbbacccaaaacc";
            x = obj.LengthOfLongestSubstringTwoDistinct(S);//10
        }

    }

}
