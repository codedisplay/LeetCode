using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class Diet_Plan_PerformanceTests
    {
        [TestMethod]
        public void AsteroidCollisionTests()
        {
            Diet_Plan_Performance obj = new Diet_Plan_Performance();

            var calories = new int[] { 1, 2, 3, 4, 5 };
            int k = 1, lower = 3, upper = 3;
            var x = obj.DietPlanPerformance(calories,k,lower,upper);//0

             calories = new int[] { 3, 2 };
            k = 2;
            lower = 0;
            upper = 1;
             x = obj.DietPlanPerformance(calories, k, lower, upper);//1

            calories = new int[] { 6, 5, 0, 0 };
            k = 2;
            lower = 1;
            upper = 5;
            x = obj.DietPlanPerformance(calories, k, lower, upper);//0



        }

    }

}
