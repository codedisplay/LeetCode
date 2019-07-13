using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Sort_ListTests
    {
        [TestMethod]
        public void SortListTests()
        {
            Sort_List obj = new Sort_List();

            ListNode l1 = new ListNode(4) { next = new ListNode(2) { next = new ListNode(1) { next = new ListNode(3) { } } } };
            var x = obj.SortList(l1);

            l1 = new ListNode(-1) { next = new ListNode(5) { next = new ListNode(3) { next = new ListNode(4) { next = new ListNode(0) { } } } } };
            x = obj.SortList(l1);



        }
    }
}