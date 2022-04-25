using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class CheckIfNandItsDoubleExistTests
    {
        [TestMethod]
        public void CheckIfExistTests()
        {
            CheckIfNandItsDoubleExist obj = new CheckIfNandItsDoubleExist();

            var values = new int[] { 10, 2, 5, 3 };
            var x = obj.CheckIfExist(values);//t

            values = new int[] { 0,0 };
            x = obj.CheckIfExist(values);//t


        }

    }
}
