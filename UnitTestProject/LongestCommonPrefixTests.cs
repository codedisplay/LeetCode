using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Longest_Common_PrefixTests
    {
        [TestMethod]
        public void LongestCommonPrefixTests()
        {
            Longest_Common_Prefix obj = new Longest_Common_Prefix();

            //        Input: ["flower", "flow", "flight"]
            //Output: "fl"

            string[] arr = new string[] { "flower", "flow", "flight" };
            var x = obj.LongestCommonPrefix(arr);

            //        Input: ["dog", "racecar", "car"]
            //Output: ""
            arr = new string[] { "dog", "racecar", "car" };
            x = obj.LongestCommonPrefix(arr);//""


            arr = new string[] { "", "" };
            x = obj.LongestCommonPrefix(arr);//""
        }
    }
}
