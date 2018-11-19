using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Reverse_StringTests
    {
        [TestMethod]
        public void ReverseStringTests()
        {
            Reverse_String obj = new Reverse_String();

            var x = obj.ReverseString("hello");//"olleh"

            x = obj.ReverseString("A man, a plan, a canal: Panama");//"amanaP :lanac a ,nalp a ,nam A"

        }
    }
}
