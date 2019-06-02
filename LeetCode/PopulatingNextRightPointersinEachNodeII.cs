using System.Collections.Generic;

namespace LeetCode
{
    public class PopulatingNextRightPointersinEachNodeII
    {
        public Node Connect(Node root)
        {
            if (root == null)
                return root;

            Queue<Node> outer = new Queue<Node>();
            if (root.left != null)
                outer.Enqueue(root.left);
            if (root.right != null)
                outer.Enqueue(root.right);

            while (outer.Count > 0)
            {
                Node prev = outer.Dequeue();
                Queue<Node> inner = new Queue<Node>();
                if (prev.left != null)
                    inner.Enqueue(prev.left);
                if (prev.right != null)
                    inner.Enqueue(prev.right);

                while (outer.Count > 0)
                {
                    Node current = outer.Dequeue();
                    prev.next = current;
                    prev = current;

                    if (current.left != null)
                        inner.Enqueue(current.left);
                    if (current.right != null)
                        inner.Enqueue(current.right);
                }

                outer = inner;
            }

            return root;
        }

        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node(int v) { val = v; }

            public Node() { }
            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }
    }
}
