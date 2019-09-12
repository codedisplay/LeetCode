using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class _4SumTests
    {
        [TestMethod]
        public void FourSumTests()
        {
            _4Sum obj = new _4Sum();

            int[] arr = new int[] { -2, -1, 0, 1, 2 };

            //  [-2, -1, 1, 2],
            var x = obj.FourSum(arr,0);

            arr = new int[] { -2, -1,0, 0, 1, 2 };

            //A solution set is:
            //[
            //  [-1,  0, 0, 1],
            //  [-2, -1, 1, 2],
            //  [-2,  0, 0, 2]
            //]

            x = obj.FourSum(arr, 0);
        }
    }
}
