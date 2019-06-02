using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCode.PopulatingNextRightPointersinEachNodeII;

namespace UnitTestProject
{
    [TestClass]
    public class PopulatingNextRightPointersinEachNodeIITests
    {
        [TestMethod]
        public void ConnectTests()
        {
            PopulatingNextRightPointersinEachNodeII obj = new PopulatingNextRightPointersinEachNodeII();


           var node = new Node(1)
            {
                left = new Node(2)
                {
                    left = new Node(4)
                    {

                    },
                    right = new Node(5)
                    {

                    }
                },
                right = new Node(3)
                {
                    right = new Node(7)
                    {

                    }
                }
            };

         var   x = obj.Connect(node);

            node = new Node(1)
            {
                left = new Node(2)
                {
                   
                }
            };

            x = obj.Connect(node);


        }
    }
}
