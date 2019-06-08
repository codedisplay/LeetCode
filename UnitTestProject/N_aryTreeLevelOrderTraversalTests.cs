using LeetCode;
using LeetCode.N_aryTreeLevelOrderTraversal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class N_aryTreeLevelOrderTraversalTests
    {
        [TestMethod]
        public void LevelOrderTests()
        {
            N_aryTreeLevelOrderTraversal obj = new N_aryTreeLevelOrderTraversal();

            Node node = new Node(1, new List<Node> {

                 new Node(3, new List<Node> {
                      new Node(5, new List<Node> { })
            {
            },
                       new Node(6, new List<Node> { })
            {
            }
                 })
            {
            },
                  new Node(2, new List<Node> { })
            {
            },
                   new Node(4, new List<Node> { })
            {
            }

            })
            {
            };

            var x = obj.LevelOrder(node);//


        }
    }
}
