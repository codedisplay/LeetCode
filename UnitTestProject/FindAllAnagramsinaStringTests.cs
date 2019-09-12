using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class FindAllAnagramsinaStringTest
    {
        [TestMethod]
        public void SearchTest()
        {
            FindAllAnagramsinaString l = new FindAllAnagramsinaString();

            var s = "cbaebabacd";
            var p = "abc";
            var x = l.FindAnagrams(s, p);//0, 6

            s = "abab";
            p = "ab";
            x = l.FindAnagrams(s, p);//0, 1, 2

            s = "ababcasdf";
            p = "ab";
            x = l.FindAnagrams(s, p);//0, 1, 2

            s = "ab";
            p = "ab";
            x = l.FindAnagrams(s, p);//0

            s = "aba";
            p = "a";
            x = l.FindAnagrams(s, p);//0,2

            s = "";
            p = "a";
            x = l.FindAnagrams(s, p);//

            s = "abacbabc";
            p = "abc";
            x = l.FindAnagrams(s, p);//
        }
    }
}
