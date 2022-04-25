using LeetCode.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class AllElementsinTwoBinarySearchTrees
    {
        public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            IList<int> values = new List<int>();

            GetAllElements(root1, root2, values);

            return values;
        }

        public void GetAllElements(TreeNode root1, TreeNode root2, IList<int> values)
        {
            //if(root1 != null)

        }
    }
}
