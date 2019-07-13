using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Letter_Case_PermutationTests
    {
        [TestMethod]
        public void LetterCasePermutationTests()
        {
            Letter_Case_Permutation obj = new Letter_Case_Permutation();

            //Input: S = "a1b2"
            //Output: ["a1b2", "a1B2", "A1b2", "A1B2"]
            string S = "a1b2";

            var x = obj.LetterCasePermutation(S);
            //Input: S = "3z4"
            //Output: ["3z4", "3Z4"]
             S = "3z4";

            x = obj.LetterCasePermutation(S);
            //Input: S = "12345"
            //Output: ["12345"]\

            S = "12345";

            x = obj.LetterCasePermutation(S);

        }
    }
}
