using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class GreatestCommonDivisorofStringsTests
    {
        [TestMethod]
        public void GcdOfStrings()
        {
            GreatestCommonDivisorofStrings obj = new GreatestCommonDivisorofStrings();

            string num1 = "ABCABC", num2 = "ABC";
            var x = obj.GcdOfStrings(num1, num2);//ABC

            num1 = "ABABAB";
            num2 = "ABAB" ;
            x = obj.GcdOfStrings(num1, num2);//AB

            num1 = "LEET";
            num2 = "CODE";
            x = obj.GcdOfStrings(num1, num2);//""

            num1 = "TAUXXTAUXXTAUXXTAUXXTAUXX";
            num2 = "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX";
            x = obj.GcdOfStrings(num1, num2);//""
        }
    }
}
