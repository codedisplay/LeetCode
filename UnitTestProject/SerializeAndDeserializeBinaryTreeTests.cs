using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using static LeetCode.SerializeAndDeserializeBinaryTree;

namespace UnitTestProject
{
    [TestClass]
    public class SerializeAndDeserializeBinaryTreeTests
    {
        [TestMethod]
        public void TestMethod()
        {
            SerializeAndDeserializeBinaryTree l = new SerializeAndDeserializeBinaryTree();

            TreeNode treeNode =
                new TreeNode(0)
                {
                    left = new TreeNode(1)
                    {
                        left = new TreeNode(2) { },
                        right = new TreeNode(2) { }
                    },
                    right = new TreeNode(3)
                    {
                        right = new TreeNode(4) { }
                    }
                };

            var x = l.serialize(treeNode);

            TreeNode tree = l.deserialize(x);

            treeNode =
               new TreeNode(1)
               {
                   left = new TreeNode(2),
                   right = new TreeNode(3)
                   {
                       left = new TreeNode(4) { },
                       right = new TreeNode(5) { }
                   }
               };

            x = l.serialize(treeNode);

            tree = l.deserialize(x);


        }
    }
}
