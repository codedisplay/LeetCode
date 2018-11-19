using LeetCode.Model;

namespace LeetCode
{
    public class RemoveDuplicatesFromSortedListII
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode node = null;
            int? previousVal = null;
            int prevValCount = 0;
            ListNode currentNode = null;

            while (head != null)
            {
                if (previousVal != null && head.val != previousVal && prevValCount == 1)
                {
                    if (currentNode != null)
                    {
                        currentNode.next = new ListNode((int)previousVal);
                        currentNode = currentNode.next;
                    }
                    else
                    {
                        node = new ListNode((int)previousVal);
                        currentNode = node;
                    }
                }

                if (head.val != previousVal)
                    prevValCount = 1;
                else
                    prevValCount++;

                previousVal = head.val;
                head = head.next;
            }

            if (prevValCount == 1)
                if (currentNode != null)
                    currentNode.next = new ListNode((int)previousVal);
                else
                    node = new ListNode((int)previousVal);

            return node;
        }
    }
}
