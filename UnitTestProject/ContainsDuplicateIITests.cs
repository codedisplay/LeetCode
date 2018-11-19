using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ContainsDuplicateIITests
    {
        [TestMethod]
        public void ContainsNearbyDuplicateTests()
        {
            ContainsDuplicateII obj = new ContainsDuplicateII();

            // MODIFY: use   Dictionary<int, int> and always save only the last iterated index and compare with compare with current Index as this would the lowest possible difference 
            //        var nums = new int[] { 1, 2, 3, 1 };
            //        int k = 3;
            //        var resp = ContainsNearbyDuplicate(nums, k);
            //        //Output: true

            //        nums = new int[] { 1, 0, 1, 1 };
            //    k = 1;
            //            resp = ContainsNearbyDuplicate(nums, k);
            //    //Output: true

            //    nums = new int[] { 1, 2, 3, 1, 2, 3 };
            //k = 2;
            //            resp = ContainsNearbyDuplicate(nums, k);
            ////Output: false
        }
    }
}
