using System.Collections.Generic;

namespace LeetCode
{
    public class LinkedListComponents
    {
        public int NumComponents(ListNode head, int[] G)
        {
            if (head == null || G.Length == 0)
                return 0;

            int connectedNodes = 0;
            List<int> dic = new List<int>();

            foreach (var g in G)
                dic.Add(g);

            while (head != null)
            {
                if (!dic.Contains(head.val))
                {
                    head = head.next;
                    continue;
                }

                head = head.next;

                while (head != null && dic.Contains(head.val))
                    head = head.next;

                connectedNodes++;
            }

            return connectedNodes;
        }

        //public int NumComponents(ListNode head, int[] G)
        //{
        //    if (head == null || G.Length == 0)
        //        return 0;

        //    int connectedNodes = 0;
        //    List<int> dic = new List<int>();

        //    foreach (var g in G)
        //        dic.Add(g);

        //    while (head != null)
        //    {
        //        if (!dic.Contains(head.val))
        //        {
        //            head = head.next;
        //            continue;
        //        }

        //        head = head.next;

        //        if (head != null && dic.Contains(head.val))
        //        {
        //            do
        //            {
        //                connectedNodes++;
        //                head = head.next;
        //            } while (head != null && dic.Contains(head.val));
        //            continue;
        //        }

        //        connectedNodes++;
        //    }

        //    return connectedNodes;
        //}


        //public int NumComponents(ListNode head, int[] G)
        //{
        //    if (head == null)
        //        return 0;

        //    List<int> dic = new List<int>();
        //    foreach (var g in G)
        //        dic.Add(g);

        //    return NumComponents(head, dic, false);
        //}

        //private int NumComponents(ListNode head, List<int> dic, bool isPreviousNodeConnected)
        //{
        //    if (head.next == null)
        //        return 0;

        //    int currentVal = 0;

        //    if (dic.Contains(head.val) && dic.Contains(head.next.val))
        //        currentVal = 1;

        //    return currentVal + NumComponents(head.next, dic, isPreviousNodeConnected);
        //}

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
