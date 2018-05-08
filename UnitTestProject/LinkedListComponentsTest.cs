using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCode.LinkedListComponents;

namespace UnitTestProject
{
    [TestClass]
    public class LinkedListComponentsTest
    {
        [TestMethod]
        public void NumComponents()
        {
            LinkedListComponents l = new LinkedListComponents();

            //head: 0->1->2->3
            ListNode node = new ListNode(0)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(3)
                    }
                }
            };

            int[] G = new int[] { 0, 1, 3 };

            Assert.AreEqual(2, l.NumComponents(node, G));

            //head: 0->1->2->3->4
            node = new ListNode(0)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(4)
                        }
                    }
                }
            };

            G = new int[] { 0, 3, 1, 4 };

            Assert.AreEqual(2, l.NumComponents(node, G));

            //head: 0->1->2
            node = new ListNode(0)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                }
            };

            G = new int[] { 0, 2 };
            Assert.AreEqual(2, l.NumComponents(node, G));

            //head: [1,2,0,4,3]
            node = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(0)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(3)
                        }
                    }
                }
            };

            G = new int[] { 3, 4, 0, 2, 1 };
            Assert.AreEqual(1, l.NumComponents(node, G));
        }
    }
}
