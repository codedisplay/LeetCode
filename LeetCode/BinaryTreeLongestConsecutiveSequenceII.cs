using LeetCode.Model;
using System;

namespace LeetCode
{
    // TODO: fix this : 132 / 159 test cases passed
    public class BinaryTreeLongestConsecutiveSequenceII
    {
        private int max = 1;

        public int LongestConsecutive(TreeNode root)
        {
            if (root == null)
                return 0;

            LongestConsecutive(root, int.MinValue, new Temp());
            return max;
        }

        public Temp LongestConsecutive(TreeNode root, int parent, Temp prev)
        {
            if (root == null)
                return prev;

            bool? incTdecF = null;
            var current = new Temp { inc = 1, dec = 1 };

            if (root.val + 1 == parent)//inc
            {
                current.dec += prev.dec;
                max = Math.Max(current.dec, max);
                incTdecF = false;
            }
            else if (root.val - 1 == parent)//dec
            {
                current.inc += prev.inc;
                max = Math.Max(current.inc, max);
                incTdecF = true;
            }

            Temp left = LongestConsecutive(root.left, root.val, current);

            Temp right = LongestConsecutive(root.right, root.val,
                new Temp
                {
                    inc = Math.Max(current.inc, root.left != null ? left.dec : 0),
                    dec = Math.Max(current.dec, root.left != null ? left.inc : 0)
                });

            current.inc = incTdecF == true ? Math.Max(left.inc, right.inc) - 1  : 1;
            current.dec = incTdecF == false ? Math.Max(left.dec, right.dec) - 1 : 1;

            return current;
        }

        public class Temp
        {
            public int inc { get; set; }

            public int dec { get; set; }
        }
    }
}
