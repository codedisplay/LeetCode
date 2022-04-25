using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class NumberofIslandsTests
    {
        [TestMethod]
        public void NumIslandsTests()
        {
            NumberofIslands obj = new NumberofIslands();

            var arr = new char[][]
            {
                new char[] {'1','1','1','1','0'},
                new char[] {'1','1','0','1','0'},
                new char[] {'1','1','0','0','0'},
                new char[] {'0','0','0','0','0'}
            };

            var x = obj.NumIslands(arr);//1

            arr = new char[][]
             {
                new char[] {'1','1','0','0','0'},
                new char[] {'1','1','0','0','0'},
                new char[] {'0','0','1','0','0'},
                new char[] {'0','0','0','1','1'}
             };
             
            x = obj.NumIslands(arr);//3

            arr = new char[][]
            {
                new char[] {'1','1','1'},
                new char[] {'0','1','0'},
                new char[] {'1','1','1'}
            };

            x = obj.NumIslands(arr);//1
        }
    }
}
