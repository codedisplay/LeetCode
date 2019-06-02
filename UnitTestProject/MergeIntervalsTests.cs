using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MergeIntervalsTests
    {
        [TestMethod]
        public void MergeTests()
        {
            MergeIntervals obj = new MergeIntervals();

            int[][] arr = new int[][]
            {
                new[] { 1,3 },
                new[] { 2,6},
                new[] {8,10 },
                new[] { 15,18},

            };

            var x = obj.Merge(arr);

            arr = new int[][]
            {
                new[] { 1,4 },
                new[] { 4,5}

            };

            x = obj.Merge(arr);

            arr = new int[][]
     {
                new[] { 1,4 },
                new[] { 0 , 4}

     };

            x = obj.Merge(arr);


            arr = new int[][]
     {
                new[] { 1,4 },
                new[] {2,3}

     };

            x = obj.Merge(arr);

        }
    }
}
