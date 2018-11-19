using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class RobotReturnToOriginTests
    {
        [TestMethod]
        public void JudgeCircleTests()
        {
            RobotReturnToOrigin obj = new RobotReturnToOrigin();

            var x = obj.JudgeCircle("UD");
            x = obj.JudgeCircle("LL");

        }
    }
}
