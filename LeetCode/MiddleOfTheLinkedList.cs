using LeetCode.Model;

namespace LeetCode
{
    public class MiddleOfTheLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode middle = head.next, current = head.next.next;
            bool isEven = true;

            while (current != null)
            {
                isEven = !isEven;

                if (isEven)
                    middle = middle.next;

                current = current.next;
            }

            return middle;
        }
    }
}
