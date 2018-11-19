using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FizzBuzzests()
        {
            Fizz_Buzz obj = new Fizz_Buzz();

            var x = obj.FizzBuzz(15);
        }
    }
}
