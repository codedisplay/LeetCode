using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class MaxConsecutiveOnesIIITests
    {
        [TestMethod]
        public void LongestOnesTests()
        {
            MaxConsecutiveOnesIII obj = new MaxConsecutiveOnesIII();

            var A = new int[] {1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0};
            var K = 2;
            var x = obj.LongestOnes(A,K);//6

           A = new int[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 };
           K = 3;
           x = obj.LongestOnes(A, K);//10

            A = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };
            K = 2;
            x = obj.LongestOnes(A, 0);//4
        }

    }

}
