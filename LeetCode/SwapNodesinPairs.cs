using LeetCode.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SwapNodesinPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode root = new ListNode(0) { next = head};
            ListNode parent = root;
            ListNode current = head;
            ListNode next = head?.next;

            while (current != null && current.next != null)
            {
                current.next = next.next;
                next.next = current;
                parent.next = next;

                parent = current;
                current = current?.next;
                next = current?.next;
            }

            return root.next;
        }
    }
}
