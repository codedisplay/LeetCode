using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ImplementstrStr__Test
    {
        [TestMethod]
        public void SearchTest()
        {
            ImplementstrStr__ l = new ImplementstrStr__();

            string haystack = "hello", needle = "ll";
            var x = l.StrStr(haystack, needle);//5

            haystack = "aaaaa";
            needle = "bba";
            x = l.StrStr(haystack, needle);//-1

            var s = "cbaebabacd";
            var p = "abc";
            x = l.StrStr(s, p);//5

            s = "abab";
            p = "ab";
            x = l.StrStr(s, p);//0

            s = "ababcasdf";
            p = "ab";
            x = l.StrStr(s, p);//0

            s = "ab";
            p = "ab";
            x = l.StrStr(s, p);//0

            s = "aba";
            p = "a";
            x = l.StrStr(s, p);//0

            s = "";
            p = "a";
            x = l.StrStr(s, p);//

            s = "abacbabc";
            p = "abc";
            x = l.StrStr(s, p);//
        }
    }
}
