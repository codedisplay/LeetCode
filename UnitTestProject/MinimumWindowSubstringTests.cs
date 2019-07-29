using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MinimumWindowSubstringTests
    {
        [TestMethod]
        public void MinWindowTests()
        {
            MinimumWindowSubstring obj = new MinimumWindowSubstring();

            string S = "ADEBFGC", T = "ABC";
            var x = obj.MinWindow(S,T);//ADEBFGC

            S = "ADOBECODEBANC";
            T = "ABC";
            x = obj.MinWindow(S, T);//BANC

            S = "ADOBECODEBANC";
            T = "ABCC";
            x = obj.MinWindow(S, T);//CODEBANC

            S = "BDAB";
            T = "AB";
            x = obj.MinWindow(S, T);//AB

            S = "A";
            T = "B";
            x = obj.MinWindow(S, T);//
        }
    }
}
