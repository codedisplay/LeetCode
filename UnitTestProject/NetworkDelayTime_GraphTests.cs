using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class NetworkDelayTime_GraphTests
    {
        [TestMethod]
        public void NetworkDelayTimeTests()
        {

            // TODO
            NetworkDelayTime_Graph obj = new NetworkDelayTime_Graph();

            int[,] arr = new int[,] {
                { 1,2,1}
            };

            var response = obj.NetworkDelayTime(arr, 2, 1);//1

            Assert.AreEqual(response, 1);

            response = obj.NetworkDelayTime(arr, 2, 2);//-1

            Assert.AreEqual(response, -1);

            arr = new int[,] {
                { 2, 1, 1 },
                { 2, 3, 1 },
                { 3, 4, 1 }
            };

            response = obj.NetworkDelayTime(arr, 4, 2);//2

            arr = new int[,] {
                { 1,2,1 },
                { 2,1,3 }
            };

            response = obj.NetworkDelayTime(arr, 2, 2);

            Assert.AreEqual(response, 3);

            arr = new int[,] {
                { 1,2,1 },
                { 2,3,2},
                { 1,3,2}
            };

            response = obj.NetworkDelayTime(arr, 3, 1);

            Assert.AreEqual(response, 2);

            arr = new int[,] {
                { 1,2,1 },
                { 2,3,2},
                { 1,3,1}
            };

            response = obj.NetworkDelayTime(arr, 3, 2);

            Assert.AreEqual(response, 2);

        }
    }
}
