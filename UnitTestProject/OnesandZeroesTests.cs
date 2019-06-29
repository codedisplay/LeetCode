using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class OnesandZeroesTests
    {
        [TestMethod]
        public void FindMaxFormTests()
        {
            OnesandZeroes obj = new OnesandZeroes();

            //Input: Array = { "10", "0001", "111001", "1", "0"}, m = 5, n = 3
            //Output: 4
            //Explanation: This are totally 4 strings can be formed by the using of 5 0s and 3 1s, which are “10,”0001”,”1”,”0”

            var str = new string[] { "10", "0001", "111001", "1", "0" };
            var x = obj.FindMaxForm(str, 5, 3);

            //Input: Array = { "10", "0", "1"}, m = 1, n = 1
            //Output: 2
            //Explanation: You could form "10", but then you'd have nothing left. Better form "0" and "1".
            str = new string[] { "10", "0", "1" };
            x = obj.FindMaxForm(str, 1, 1);

            str = new string[] { "1", "", "1" };
            x = obj.FindMaxForm(str, 1, 0);

            str = new string[] { "1", "001", "1" };
            x = obj.FindMaxForm(str, 0, 0);

            str = new string[] { "011", "1", "11", "0", "010", "1", "10", "1", "1", "0", "0", "0", "01111", "011", "11", "00", "11", "10", "1", "0", "0", "0", "0", "101", "001110", "1", "0", "1", "0", "0", "10", "00100", "0", "10", "1", "1", "1", "011", "11", "11", "10", "10", "0000", "01", "1", "10", "0"};
            x = obj.FindMaxForm(str, 44, 39);//45
  
        }
    }
}
