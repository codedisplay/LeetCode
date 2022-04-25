using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MinimumNumberofFrogsCroakingTests
    {
        [TestMethod]
        public void MinNumberOfFrogsTests()
        {
            MinimumNumberofFrogsCroaking obj = new MinimumNumberofFrogsCroaking();

            var croakOfFrogs ="croakcroak";
            var x = obj.MinNumberOfFrogs(croakOfFrogs);//1

            croakOfFrogs = "crcoakroak";
            x = obj.MinNumberOfFrogs(croakOfFrogs);//2

            croakOfFrogs = "croakcrook";
            x = obj.MinNumberOfFrogs(croakOfFrogs);//-1

            croakOfFrogs = "croakcroa";
            x = obj.MinNumberOfFrogs(croakOfFrogs);//-1
        }

    }
}
