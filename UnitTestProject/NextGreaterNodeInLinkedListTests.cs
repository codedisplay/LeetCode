using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class NextGreaterNodeInLinkedListTests
    {
        [TestMethod]
        public void NextLargerNodesTests()
        {
            //        Input:
            //[1,7,5,1,9,2,5,1]
            //        Output:
            //[9,9,9,9,0,5,0,0]
            //        Expected as per question:
            //[7,9,9,9,0,5,0,0]

            NextGreaterNodeInLinkedList obj = new NextGreaterNodeInLinkedList();

            ListNode node = new ListNode(1)
            {
                next = new ListNode(7)
                {
                    next = new ListNode(5)
                    {
                        next = new ListNode(1)
                        {
                            next = new ListNode(9)
                            {
                                next = new ListNode(2)
                                {
                                    next = new ListNode(5)
                                    {
                                        next = new ListNode(1)
                                    }
                                }
                            }
                        }
                    }
                }
            };

           var x= obj.NextLargerNodes(node);

            node = new ListNode(8)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(5)
                        {
                            next = new ListNode(7)
                            {
                                next = new ListNode(9)
                                {
                                }
                            }
                        }
                    }
                }
            };

            x = obj.NextLargerNodes(node);//9,7,5,7,9,0

            node = new ListNode(2)
            {
                next = new ListNode(7)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(5)
                            {
                        
                            }
                        }
                    }
                }
            };

            x = obj.NextLargerNodes(node);//7,0,5,5,0


            node = new ListNode(9)
            {
                next = new ListNode(7)
                {
                    next = new ListNode(6)
                    {
                        next = new ListNode(7)
                        {
                            next = new ListNode(6)
                            {
                                next = new ListNode(9)
                                {
                                }
                            }
                        }
                    }
                }
            };

            x = obj.NextLargerNodes(node);//[0, 9, 7, 9, 9, 0]
        }
    }
}
