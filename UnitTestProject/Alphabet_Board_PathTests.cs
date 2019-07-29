using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Alphabet_Board_PathTests
    {
        [TestMethod]
        public void AlphabetBoardPathTests()
        {
            Alphabet_Board_Path obj = new Alphabet_Board_Path();

            var target = "leet";
            var x = obj.AlphabetBoardPath(target);//DDR!UURRR!!DDD!

            target = "code";
            x = obj.AlphabetBoardPath(target);//RR!DDRR!UUL!R!

            target = "zdz";
            x = obj.AlphabetBoardPath(target);//"DDDDD!UUUUURRR!DDDDLLLD!"

        }
    }
}
