using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Keyboard_RowTests
    {
        [TestMethod]
        public void FindWordsTests()
        {
            Keyboard_Row obj = new Keyboard_Row();

            var x = new string[] { "Hello", "Alaska", "Dad", "Peace" };
            var y = obj.FindWords(x);

            x = new string[] { "Aasdfghjkl", "Qwertyuiop", "zZxcvbnm" };
            y = obj.FindWords(x);

        }
    }
}
