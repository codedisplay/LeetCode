using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class VerifyPreorderSerializationOfaBinaryTreeTests
    {
        [TestMethod]
        public void IsValidSerializationTest()
        {
            VerifyPreorderSerializationOfaBinaryTree l = new VerifyPreorderSerializationOfaBinaryTree();

            //Assert.IsTrue(l.IsValidSerialization("9,3,4,#,#,1,#,#,2,#,6,#,#"));

            //Assert.IsFalse(l.IsValidSerialization("1,#"));

            //Assert.IsFalse(l.IsValidSerialization("9,#,#,1"));

            //Assert.IsFalse(l.IsValidSerialization("#,#,3,5,#"));

            Assert.IsTrue(l.IsValidSerialization("#"));
        }
        }
}
