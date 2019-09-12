using LeetCode.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ReverseLinkedListII
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            ListNode root = new ListNode(0) { next = head };
            ListNode current = root;
            int pos = 1;

            while (current.next != null && pos != m)
            {
                current = current.next;
                pos++;
            }

            ListNode left = null;
            ListNode right = current?.next;
            ListNode leftEnd = current?.next;

            while (right != null && pos <= n)
            {
                var next = right.next;
                right.next = left;
                left = right;
                right = next;
                pos++;
            }

            current.next = left;
            leftEnd.next = right;

            return root.next;
        }
    }
}
