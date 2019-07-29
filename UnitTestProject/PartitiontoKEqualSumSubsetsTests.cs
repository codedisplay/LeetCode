using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class PartitiontoKEqualSumSubsetsTests
    {
        [TestMethod]
        public void CanPartitionKSubsetsTests()
        {
            PartitiontoKEqualSumSubsets obj = new PartitiontoKEqualSumSubsets();

            var arr = new int[] { 4, 3, 2, 3, 5, 2, 1 };
            var x = obj.CanPartitionKSubsets(arr, 4);//t

            obj = new PartitiontoKEqualSumSubsets();
            arr = new int[] { 2, 2, 2, 2, 3, 4, 5 };
            x = obj.CanPartitionKSubsets(arr, 4);//f

            obj = new PartitiontoKEqualSumSubsets();
            arr = new int[] { 6, 6, 6, 7, 7, 7, 7, 7, 7, 10, 10, 10 };
            x = obj.CanPartitionKSubsets(arr, 3);//t

            obj = new PartitiontoKEqualSumSubsets();
            arr = new int[] { 1, 1, 1};
            x = obj.CanPartitionKSubsets(arr, 1);//t

            obj = new PartitiontoKEqualSumSubsets();
            arr = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            x = obj.CanPartitionKSubsets(arr, 1);//t

            obj = new PartitiontoKEqualSumSubsets();
            arr = new int[] { 2, 2, 2, 2, 2, 5, 7, 10, 13 };
            x = obj.CanPartitionKSubsets(arr, 3);//t


        }
    }
}
