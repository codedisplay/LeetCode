using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class DecodeStringTests
    {
        [TestMethod]
        public void Decode_StringTests()
        {
            Decode_String obj = new Decode_String();

            var x = obj.DecodeString("3[a]2[bc]");//"aaabcbc"

            x = obj.DecodeString("3[a2[c]]");//"accaccacc"

            x = obj.DecodeString("2[abc]3[cd]ef");//"abcabccdcdcdef"
        }
    }
}
