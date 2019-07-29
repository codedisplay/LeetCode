using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class TwoSumTests
    {
        [TestMethod]
        public void TwoSum_Tests()
        {
            TwoSum obj = new TwoSum();


            obj.Add(3);
            obj.Add(1);
            obj.Add(2);

            var x = obj.Find(3);//t
            x = obj.Find(6);//f



            obj = new TwoSum();


            obj.Add(0);
            obj.Add(-1);
            obj.Add(-1);
            obj.Add(0);
            x = obj.Find(-2);//t
            x = obj.Find(0);//t
            x = obj.Find(-1);//t
            x = obj.Find(1);//f

        }
    }
}
