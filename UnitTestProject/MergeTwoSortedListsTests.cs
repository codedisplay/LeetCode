using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MergeTwoSortedListsTests
    {
        [TestMethod]
        public void MergeTwoListsTests()
        {
            MergeTwoSortedLists obj = new MergeTwoSortedLists();

            ListNode l1 = new ListNode(1) { next = new ListNode(2) { next = new ListNode(4) { } } };

            ListNode l2 = new ListNode(1) { next = new ListNode(3) { next = new ListNode(4) { } } };

            var x = obj.MergeTwoLists(l1, l2);


            l1 = null;

            l2 = new ListNode(1) { next = new ListNode(3) { next = new ListNode(4) { } } };

            x = obj.MergeTwoLists(l1, l2);


            l1 = new ListNode(1) { next = new ListNode(2) { next = new ListNode(4) { } } };

            l2 = null;

            x = obj.MergeTwoLists(l1, l2);
        }
    }
}