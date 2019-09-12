using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class FindSmallestLetterGreaterThanTargetTests
    {
        [TestMethod]
        public void NextGreatestLetterTests()
        {
            FindSmallestLetterGreaterThanTarget obj = new FindSmallestLetterGreaterThanTarget();

            char[] letters = new char[] { 'c', 'f', 'j' };
            var x = obj.NextGreatestLetter(letters, 'a');
            Assert.AreEqual(x, 'c');

            letters = new char[] { 'c', 'f', 'j' };
            x = obj.NextGreatestLetter(letters, 'c');
            Assert.AreEqual(x, 'f');

            letters = new char[] { 'c', 'f', 'j' };
            x = obj.NextGreatestLetter(letters, 'd');
            Assert.AreEqual(x, 'f');

            letters = new char[] { 'c', 'f', 'j' };
            x = obj.NextGreatestLetter(letters, 'g');
            Assert.AreEqual(x, 'j');

            letters = new char[] { 'c', 'f', 'j' };
            x = obj.NextGreatestLetter(letters, 'j');
            Assert.AreEqual(x, 'c');

            letters = new char[] { 'c', 'f', 'j' };
            x = obj.NextGreatestLetter(letters, 'k');
            Assert.AreEqual(x, 'c');

        }

    }
}
