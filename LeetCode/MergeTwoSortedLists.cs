using LeetCode.Model;

namespace LeetCode
{
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode root = new ListNode(0);
            ListNode current = root;

            while (true)
            {
                if (l1 == null)
                {
                    current.next = l2;
                    return root.next;
                }
                if (l2 == null)
                {
                    current.next = l1;
                    return root.next;
                }

                if (l1.val < l2.val)
                {
                    current.next = new ListNode(l1.val);
                    l1 = l1.next;
                }
                else
                {
                    current.next = new ListNode(l2.val);
                    l2 = l2.next;
                }

                current = current.next;
            }
        }
    }
}
