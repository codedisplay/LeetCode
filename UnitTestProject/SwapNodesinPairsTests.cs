using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class SwapNodesinPairsTests
    {
        [TestMethod]
        public void SwapPairsTests()
        {
            SwapNodesinPairs obj = new SwapNodesinPairs();


            ListNode current = new ListNode(1) {
            next = new ListNode(2) {
            next = new ListNode(3) {
            next= new ListNode(4) { }
            }
            }
            
            };

            var x = obj.SwapPairs(current);// 2 1 4 3

            current = new ListNode(1)
            {
                

            };

             x = obj.SwapPairs(current);

            current = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                    }
                }

            };

            x = obj.SwapPairs(current);

            current = null;
            x = obj.SwapPairs(current);
        }
    }
}
