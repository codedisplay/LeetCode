using LeetCode.Model;
using System.Collections.Generic;

namespace LeetCode
{
    public class AllNodesDistanceKinBinaryTree
    {
        public IList<int> DistanceK(TreeNode root, TreeNode target, int K)
        {
            int? currentDist = null;
            IList<int> nodes = new List<int>();

            FindNode(root, target, K, nodes, ref currentDist);

            return nodes;
        }

        public bool FindNode(TreeNode root, TreeNode target, int K, IList<int> nodes, ref int? currentDist)
        {
            if (root == null)
                return false;

            if (root.val == target.val)
            {
                currentDist = 0;
                FindKDistNodes(root, K, nodes, 0);
                return true;
            }

            var isFound = FindNode(root.left, target, K, nodes, ref currentDist);

            if (isFound)
                FindKDistNodes(root, K, nodes, currentDist.Value + 1, true);
            else
            {
                isFound = FindNode(root.right, target, K, nodes, ref currentDist);

                if (isFound)
                    FindKDistNodes(root, K, nodes, currentDist.Value + 1, false, true);
            }

            if (isFound)
                currentDist++;

            return isFound;
        }

        public void FindKDistNodes(TreeNode root, int K, IList<int> nodes, int currentDist, bool skipLeft = false, bool skipRight = false)
        {
            if (root == null || currentDist > K)
                return;

            if (currentDist == K)
                nodes.Add(root.val);

            if (!skipLeft)
                FindKDistNodes(root.left, K, nodes, currentDist + 1);
            if (!skipRight)
                FindKDistNodes(root.right, K, nodes, currentDist + 1);
        }

        //public int DistanceK(TreeNode root, TreeNode target, int K, int currentDistance, IList<int> nodes)
        //{
        //    if (root == null)
        //        return currentDistance;

        //    int response = -1;

        //    if (currentDistance > -1)
        //    {

        //    }
        //    else if (currentDistance == K)
        //    {
        //        nodes.Add(root.val);
        //    }
        //    if (root.val == target.val)
        //    {
        //        response = 1;
        //    }
        //    else
        //    {

        //    }

        //    int newDist = currentDistance != -1 ? currentDistance + 1 : -1;

        //    int left = DistanceK(root, target, K, newDist, nodes);

        //    if(left >)

        //    int right = 0;



        //    return response;
        //    //int newDistance= currentDistance;

        //    //if (currentDistance > K)
        //    //    return currentDistance;
        //    //else if (currentDistance == K)
        //    //{
        //    //    nodes.Add(root.val);
        //    //    newDistance = 1;
        //    //}
        //    //else
        //    //    newDistance = currentDistance+1;

        //    //DistanceK(root, target, K, , nodes);

        //}

        //public IList<int> DistanceK(TreeNode root, TreeNode target, int K)
        //{
        //    IList<int> nodes = new List<int>();

        //    //if()

        //    return nodes;
        //}

        //public int DistanceK(TreeNode root, TreeNode target, int K, IList<int> nodes)
        //{
        //    //Queue<TreeNode> stack = new Queue<TreeNode>();

        //    //while(stack.Count > 0)
        //    //{
        //    //    int size = stack.Count;

        //    //    for (int i = 0; i < size; i++)
        //    //    {
        //    //        int val = 
        //    //    }
        //    //}
        //}
    }
}
