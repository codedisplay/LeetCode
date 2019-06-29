using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Largest_Divisible_SubsetcsTests
    {
        [TestMethod]
        public void LargestDivisibleSubsetTests()
        {
            Largest_Divisible_Subsetcs obj = new Largest_Divisible_Subsetcs();


            //        Input: [1, 2, 3]
            //Output: [1, 2](of course, [1, 3] will also be ok)
            int[] array = new int[] { 1, 2, 3 };
            var x = obj.LargestDivisibleSubset(array);

            //        Input: [1, 2, 4, 8]
            //Output: [1, 2, 4, 8]
            array = new int[] { 1, 2, 4, 8 };
            x = obj.LargestDivisibleSubset(array);

            array = new int[] { 3, 4, 8 };
            x = obj.LargestDivisibleSubset(array);

            array = new int[] { 546, 669 };
            x = obj.LargestDivisibleSubset(array);

            array = new int[] { };
            x = obj.LargestDivisibleSubset(array);

            array = new int[] { 1 };
            x = obj.LargestDivisibleSubset(array);//[1]

            //[4,8,10,240] --> [4,8,240]
    }
    }
}
