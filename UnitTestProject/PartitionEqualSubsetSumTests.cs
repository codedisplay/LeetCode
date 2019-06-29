using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class PartitionEqualSubsetSumTests
    {
        [TestMethod]
        public void CanPartitionTests()
        {
            PartitionEqualSubsetSum obj = new PartitionEqualSubsetSum();

            //Input: [1, 5, 11, 5]
            //Output: true
            //Explanation: The array can be partitioned as [1, 5, 5] and[11].
            int[] array = new int[] { 1, 5, 11, 5 };
            var x = obj.CanPartition(array);

            //Input: [1, 2, 3, 5]
            //Output: false
            //Explanation: The array cannot be partitioned into equal sum subsets.
            array = new int[] { 1, 2, 4, 8 };
            x = obj.CanPartition(array);

        }
    }
}
