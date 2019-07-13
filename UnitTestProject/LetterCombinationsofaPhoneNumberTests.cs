using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class LetterCombinationsofaPhoneNumberTests
    {
        [TestMethod]
        public void LetterCombinationsTests()
        {
            LetterCombinationsofaPhoneNumber obj = new LetterCombinationsofaPhoneNumber();

            // Input: "23"
            //Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
            string S = "23";
            var x = obj.LetterCombinations(S);

            S = "2";
            x = obj.LetterCombinations(S);

        }
    }
}
