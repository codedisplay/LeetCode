using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UniqueMorseCodeWordsTests
    {
        [TestMethod]
        public void UniqueMorseRepresentationsTests()
        {
            UniqueMorseCodeWords obj = new UniqueMorseCodeWords();

            var words = new string[] { "gin", "zen", "gig", "msg" };
            var x = obj.UniqueMorseRepresentations(words);
        }
    }
}
