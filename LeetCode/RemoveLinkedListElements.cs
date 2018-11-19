using LeetCode.Model;

namespace LeetCode
{
    public class RemoveLinkedListElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return null;

            while (head != null && head.val == val)
            {
                head = head.next;
            }

            if (!(head != null && head.next != null))
                return head;

            ListNode currentNode = head;

            while (currentNode.next != null)
            {
                if (currentNode.next.val != val)
                    currentNode = currentNode.next;
                else
                {
                    currentNode.next = currentNode.next.next;
                }
            }

            return head;
        }
    }
}
