using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MiddleOfTheLinkedListTests
    {
        [TestMethod]
        public void MiddleNodeTests()
        {
            MiddleOfTheLinkedList obj = new MiddleOfTheLinkedList();

            var node = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4) { next = new ListNode(5) { } }
                    }
                }
            };
            obj.MiddleNode(node);

            node = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                            {
                                next = new ListNode(6) { }
                            }
                        }
                    }
                }
            };

            obj.MiddleNode(node);
        }
    }
}
