using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class RemoveDuplicatesFromSortedListTests
    {
        [TestMethod]
        public void DeleteDuplicatesTests()
        {
            RemoveDuplicatesFromSortedList obj = new RemoveDuplicatesFromSortedList();

            ////Input: 1->1->2
            ////Output: 1->2

            var node = new ListNode(1) { next = new ListNode(1) { next = new ListNode(2) } };
            var x = obj.DeleteDuplicates(node);

            ////        Input: 1->1->2->3->3
            ////Output: 1->2->3
            node = new ListNode(1) { next = new ListNode(1) { next = new ListNode(2) { next = new ListNode(3) { next = new ListNode(3) } } } };
            x = obj.DeleteDuplicates(node);
        }
    }
}
