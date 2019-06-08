using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class AddOneRowtoTreeTests
    {
        [TestMethod]
        public void AddOneRowTests()
        {
            AddOneRowtoTree obj = new AddOneRowtoTree();

            TreeNode node = new TreeNode(4)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(3)
                    {
                    },
                    right = new TreeNode(1)
                    {
                    }
                },
                right = new TreeNode(6)
                {
                    left = new TreeNode(5)
                    {
                    },
                }
            };

            var x = obj.AddOneRow(node, 1, 2);//

            node = new TreeNode(4)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(3)
                    {
                    },
                    right = new TreeNode(1)
                    {
                    }
                },

            };

            x = obj.AddOneRow(node, 1, 3);//

            node = new TreeNode(4)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(3)
                    {
                    },
                    right = new TreeNode(1)
                    {
                    }
                },

            };

            x = obj.AddOneRow(node, 0, 1);//

            node = Helpers.GenerateBinaryTree(new int?[] { 1, 2, 3, 4 });

            x = obj.AddOneRow(node, 5, 4);//


            node = Helpers.GenerateBinaryTree(new int?[] { 4, 2, 6, 3, 1, 5 });

            x = obj.AddOneRow(node, 1, 3);//
        }
    }
}
