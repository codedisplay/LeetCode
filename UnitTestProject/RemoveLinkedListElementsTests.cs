using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class RemoveLinkedListElementsTests
    {
        [TestMethod]
        public void RemoveElementsTests()
        {
            RemoveLinkedListElements obj = new RemoveLinkedListElements();

            ////        Input: 1->2->6->3->4->5->6, val = 6
            ////Output: 1->2->3->4->5
            var input = new ListNode(1) { next = new ListNode(2) { next = new ListNode(6) { next = new ListNode(3) { next = new ListNode(4) { next = new ListNode(5) { next = new ListNode(6) } } } } } };

            var x = obj.RemoveElements(input, 6);
        }
    }
}
