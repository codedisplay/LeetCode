using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class N_AryTreePreorderTraversalTests
    {
        [TestMethod]
        public void TrimBSTTests()
        {
            N_AryTreePreorderTraversal obj = new N_AryTreePreorderTraversal();

            NArrayNode arrayNode =
        new NArrayNode(1, new List<NArrayNode>
            {new NArrayNode(3,new List<NArrayNode>{
                                    new NArrayNode(5,new List<NArrayNode>()),
                                    new NArrayNode(6,new List<NArrayNode>())}),
                                 new NArrayNode(2, new List<NArrayNode>()),
                                 new NArrayNode(4, new List<NArrayNode>()) });

            obj.Preorder(arrayNode);
        }
    }
}
