using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ReverseLinkedListIITests
    {
        [TestMethod]
        public void ReverseBetweenTests()
        {
            ReverseLinkedListII obj = new ReverseLinkedListII();

            var node = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5) { }
                        }
                    }

                }
            };

            //1 2 3 4 5  -> 1 4 3 2 5
            var x = obj.ReverseBetween(node, 2, 4);

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
                                next = new ListNode(6)
                                {
                                    next = new ListNode(7)
                                    {
                                    }
                                }
                            }
                        }
                    }

                }
            };

            //1 2 3 4 5 6 7 -> 1 2 3 4 5 6 7
            x = obj.ReverseBetween(node, 1, 1);

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
                                next = new ListNode(6)
                                {
                                    next = new ListNode(7)
                                    {
                                    }
                                }
                            }
                        }
                    }

                }
            };

            //1 2 3 4 5 6 7 -> 7 6 5 4 3 2 1
            x = obj.ReverseBetween(node, 1, 7);

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
                                next = new ListNode(6)
                                {
                                    next = new ListNode(7)
                                    {
                                    }
                                }
                            }
                        }
                    }

                }
            };

            //1 2 3 4 5 6 7-> 1 2 3 4 5 7 6
            x = obj.ReverseBetween(node, 6, 7);

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
                                next = new ListNode(6)
                                {
                                    next = new ListNode(7)
                                    {
                                    }
                                }
                            }
                        }
                    }

                }
            };

            //1 2 3 4 5 6 7 -> 2 1 3 4 5 6 7
            x = obj.ReverseBetween(node, 1, 2);

            node = new ListNode(1)
            {
            };

            x = obj.ReverseBetween(node, 1, 1);

            node = new ListNode(1)
            {
            };

            x = obj.ReverseBetween(node, 1, 1);

            node = new ListNode(1)
            {
                next = new ListNode(2)
                {
                }
            };

            x = obj.ReverseBetween(node, 1, 2);
        }
    }
}
