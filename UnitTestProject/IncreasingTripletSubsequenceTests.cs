using LeetCode;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class IncreasingTripletSubsequenceTests
    {
        [TestMethod]
        public void IncreasingTripletTests()
        {
            IncreasingTripletSubsequence obj = new IncreasingTripletSubsequence();


            var arr = new int[] { 1, 2, 3, 4, 5 };
            var x = obj.IncreasingTriplet(arr);//t

            arr = new int[] { 5, 4, 3, 2, 11 };
            x = obj.IncreasingTriplet(arr);//f

            arr = new int[] { 5,6,1,7,6 };
            x = obj.IncreasingTriplet(arr);//t

            arr = new int[] { 5, 6, 1,5,2,3};
            x = obj.IncreasingTriplet(arr);//t

            arr = new int[] { 5, 1, 5, 5, 2, 5, 4 };
            x = obj.IncreasingTriplet(arr);//t

            arr = new int[] { 2,1,5,0,3 };
            x = obj.IncreasingTriplet(arr);//f
        }
    }
}