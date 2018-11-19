using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class N_AryTreePostorderTraversalTests
    {
        [TestMethod]
        public void PostorderTests()
        {
            N_AryTreePostorderTraversal obj = new N_AryTreePostorderTraversal();

            NArrayNode arrayNode =
                new NArrayNode(1, new List<NArrayNode>
                    {new NArrayNode(3,new List<NArrayNode>{
                                new NArrayNode(5,new List<NArrayNode>()),
                                new NArrayNode(6,new List<NArrayNode>())}),
                             new NArrayNode(2, new List<NArrayNode>()),
                             new NArrayNode(4, new List<NArrayNode>()) });

            obj.Postorder(arrayNode);

        }
    }
}
