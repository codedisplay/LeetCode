using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ShortestDistanceToACharacterTests
    {
        [TestMethod]
        public void ShortestToCharTests()
        {
            ShortestDistanceToACharacter obj = new ShortestDistanceToACharacter();

            var x = obj.ShortestToChar("loveleetcode", 'e');
            x = obj.ShortestToChar("aaba", 'b');

        }
    }
}
