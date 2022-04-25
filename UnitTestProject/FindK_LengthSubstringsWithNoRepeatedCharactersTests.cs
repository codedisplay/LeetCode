using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class FindK_LengthSubstringsWithNoRepeatedCharactersTests
    {
        [TestMethod]
        public void NumKLenSubstrNoRepeatsTests()
        {
            FindK_LengthSubstringsWithNoRepeatedCharacters obj = new FindK_LengthSubstringsWithNoRepeatedCharacters();

            var S = "havefunonleetcode";
            int K = 5;
            var x = obj.NumKLenSubstrNoRepeats(S, K);//6

            S = "home";
            K = 5;
            x = obj.NumKLenSubstrNoRepeats(S, K);//0





        }

    }

}
