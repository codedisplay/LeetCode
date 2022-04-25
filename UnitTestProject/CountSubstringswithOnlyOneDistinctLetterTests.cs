using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class CountSubstringswithOnlyOneDistinctLetterTests
    {
        [TestMethod]
        public void GetAllElementsTests()
        {
            CountSubstringswithOnlyOneDistinctLetter obj = new CountSubstringswithOnlyOneDistinctLetter();

            var x = obj.CountLetters("aaaba");//8

            x = obj.CountLetters("aaaaaaaaaa");//55

        }

    }

}
