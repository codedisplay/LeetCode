using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Remove_Duplicate_LettersTests
    {
        [TestMethod]
        public void RemoveDuplicateLettersTests()
        {
            Remove_Duplicate_Letters l = new Remove_Duplicate_Letters();
            var x = l.RemoveDuplicateLetters("bcabc");//abc
            x = l.RemoveDuplicateLetters("cbacdcbc");//acdb

        }
    }
}
