using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class RemoveDuplicatesFromSortedListIITests
    {
        [TestMethod]
        public void DeleteDuplicatesTests()
        {
            RemoveDuplicatesFromSortedListII obj = new RemoveDuplicatesFromSortedListII();

            ////Input: 1->2->3->3->4->4->5
            ////Output: 1->2->5

            var node = new ListNode(1) { next = new ListNode(2) { next = new ListNode(3) { next = new ListNode(3) { next = new ListNode(4) { next = new ListNode(4) { next = new ListNode(5) } } } } } };
            var x = obj.DeleteDuplicates(node);

            ////Input: 1->1->1->1->2->3
            ////Output: 2->3
            node = new ListNode(1) { next = new ListNode(1) { next = new ListNode(1) { next = new ListNode(1) { next = new ListNode(2) { next = new ListNode(3) } } } } };
            x = obj.DeleteDuplicates(node);

            node = new ListNode(1);
            x = obj.DeleteDuplicates(node);
        }
    }
}
