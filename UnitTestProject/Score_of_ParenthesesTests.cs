using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Score_of_ParenthesesTests
    {
        [TestMethod]
        public void ScoreOfParenthesesTests()
        {
            Score_of_Parentheses obj = new Score_of_Parentheses();
            int count = obj.ScoreOfParentheses("()");//1

            count = obj.ScoreOfParentheses("(())");//2

            count = obj.ScoreOfParentheses("()()");//2

            count = obj.ScoreOfParentheses("(()(()))");//6

            count = obj.ScoreOfParentheses("(())()(())");//5
        }
    }
}
