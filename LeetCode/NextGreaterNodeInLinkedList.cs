using LeetCode.Model;
using System.Collections.Generic;

namespace LeetCode
{
    public class NextGreaterNodeInLinkedList
    {
        public int[] NextLargerNodes(ListNode head)
        {
            if (head == null)
                return new int[0];

            Stack<int> stack = new Stack<int>();

            while (head != null)
            {
                stack.Push(head.val);
                head = head.next;
            }

            int i = stack.Count, currentMax = stack.Pop(), prev = currentMax, current;
            int[] arr = new int[i];
            i--;

            while (stack.Count > 0)
            {
                i--;
                current = stack.Pop();

                if (current < prev)
                    arr[i] = prev;
                else if (current == prev)
                    arr[i] = arr[i + 1];
                else if (current >= currentMax)
                    currentMax = current;// arr[i] = 0; --> not needed as by default it's 0
                else
                {
                    int j = i + 1;

                    while (j < arr.Length)
                    {
                        if (current < arr[j])
                        {
                            arr[i] = arr[j];
                            break;
                        }

                        j++;
                    }
                }

                prev = current;
            }

            return arr;
        }
        //TOFIX
        // O(n) time not possible 
        // DO with for -> while() with processed numbers
        //public int[] NextLargerNodes(ListNode head)
        //{
        //    if (head == null)
        //        return new int[0];

        //    int i = 0, currentMax = 0;
        //    Queue<NodeData> queue = new Queue<NodeData>();

        //    var temp = head;
        //    while (temp != null)
        //    {
        //        temp = temp.next;
        //        queue.Enqueue(new NodeData(head.val, i));
        //        i++;
        //    }

        //    int[] arr = new int[i];
        //    i = 0;
        //    NodeData prev = new NodeData(head.val, 0);
        //    head = head.next;


        //    //while (head != null)
        //    //{
        //    //    if (prev.Val < head.val)
        //    //        arr[i] = head.val;
        //    //    else if (prev.Val >= head.val)
        //    //        queue.Enqueue(prev);

        //    //    i++;
        //    //    prev = new NodeData(head.val, i);
        //    //    head = head.next;
        //    //}

        //    prev = queue.Dequeue();

        //    while (queue.Count> 0)
        //    {
        //        var current = queue.Dequeue();

        //        if (prev.Val < current.Val)
        //            arr[prev.Val] = current.Val;
        //        else if (prev.Val >= head.val)
        //            queue.Enqueue(prev);

        //        prev = current;
        //    }

        //    return arr;
        //}

        //public class NodeData
        //{
        //    public NodeData(int value, int index)
        //    {
        //        Val = value;
        //        Index = index;
        //    }

        //    public int Index { get; set; }

        //    public int Val { get; set; }
        //}

        //public int[] NextLargerNodes(ListNode head)
        //{
        //    if (head == null)
        //        return new int[0];

        //    int i = 0, currentMax = 0;

        //    var temp = head;
        //    while (temp != null)
        //    {
        //        temp = temp.next;
        //        i++;
        //    }

        //    int[] arr = new int[i];
        //    i = 0;
        //    NodeData prev = new NodeData(head.val, 0);
        //    head = head.next;
        //    Stack<NodeData> stack = new Stack<NodeData>();

        //    while (head != null)
        //    {
        //        if (prev.Val < head.val)
        //        {
        //            arr[i] = head.val;
        //        }
        //        else if (prev.Val >= head.val)
        //        {
        //            stack.Push(prev);
        //        }

        //        i++;
        //        prev = new NodeData(head.val, i);
        //        head = head.next;
        //    }

        //    return arr;
        //}

        //public int[] NextLargerNodes(ListNode head)
        //{
        //    if (head == null)
        //        return new int[0];

        //    int i = 0, currentMax = head.val, totalCount = 0;
        //    Stack<NodeData> stack = new Stack<NodeData>();
        //    int[] arr = new int[totalCount];
        //    NodeData prev = new NodeData(head.val, i);
        //    head = head.next;

        //    while (head != null)
        //    {
        //        head = head.next;
        //        totalCount++;
        //    }

        //    while (head != null)
        //    {
        //        if (prev.Val >= head.val)
        //        {
        //            stack.Push(prev);
        //        }
        //        else
        //        {
        //            int backIndex = 1;
        //            int current = head.val;

        //            while (i - backIndex > -1 && arr[i - backIndex] < head.val && prev != null)
        //            {
        //                arr[i - backIndex] = head.val;
        //                prev = stack.Pop();
        //                backIndex++;
        //            }


        //        }

        //        prev = new NodeData(head.val, i);
        //        head = head.next;
        //        i++;
        //    }

        //    return arr;
        //}


        // Working: for returning the next max value from the entire array


        //public int[] NextLargerNodes(ListNode head)
        //{
        //    if (head == null)
        //        return new int[0];

        //    Stack<int> stack = new Stack<int>();

        //    while (head != null)
        //    {
        //        stack.Push(head.val);
        //        head = head.next;
        //    }

        //    int i = stack.Count, currentMax = 0, val;
        //    int[] arr = new int[i];

        //    while (stack.Count > 0)
        //    {
        //        i--;
        //        val = stack.Pop();
        //        if (val >= currentMax)
        //        {
        //            currentMax = val;
        //            arr[i] = 0;
        //        }
        //        else
        //            arr[i] = currentMax;
        //    }

        //    return arr;
        //}
    }
}
