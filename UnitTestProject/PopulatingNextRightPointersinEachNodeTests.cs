using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCode.PopulatingNextRightPointersinEachNode;

namespace UnitTestProject
{
    [TestClass]
    public class PopulatingNextRightPointersinEachNodeTests
    {
        [TestMethod]
        public void ConnectTests()
        {
            PopulatingNextRightPointersinEachNode obj = new PopulatingNextRightPointersinEachNode();


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
                    left = new Node(6)
                    {

                    },
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
                    left = new Node(4)
                    {

                    },
                    right = new Node(5)
                    {


                    }
                },
                right = new Node(3)
                {
                    left = new Node(6)
                    {

                    },
                    right = new Node(7)
                    {

                    }
                }
            };
        }
    }
}
