using LeetCode.Model;

namespace LeetCode
{
    public class RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode node = null;

            if (head != null)
            {
                node = new ListNode(head.val);
                head = head.next;
            }

            var currentNode = node;
            while (head != null)
            {
                if (head.val != currentNode.val)
                {
                    currentNode.next = new ListNode(head.val);
                    currentNode = currentNode.next;
                }

                head = head.next;
            }

            return node;
        }
    }
}
