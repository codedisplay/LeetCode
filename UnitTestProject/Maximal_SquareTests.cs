using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Maximal_SquareTests
    {
        [TestMethod]
        public void MaximalSquareTests()
        {

      
            Maximal_Square obj = new Maximal_Square();

            /**
       Input: 

      1 0 1 0 0
      1 0 1 1 1
      1 1 1 1 1
      1 0 0 1 0

      Output: 4
       */
            char[][] array2D = new char[][]
                                {
                                   "10100".ToCharArray(),
                                   "10111".ToCharArray(),
                                   "11111".ToCharArray(),
                                   "10100".ToCharArray()
                                };
            int param_1 = obj.MaximalSquare(array2D);//4

             array2D = new char[][]
                        {
                                   "1".ToCharArray()
                        };
            param_1 = obj.MaximalSquare(array2D);//1

            array2D = new char[][]
                       {
                                    "10".ToCharArray()
                       };
            param_1 = obj.MaximalSquare(array2D);//1

            array2D = new char[][]
             {
                                    "1111".ToCharArray(),
                                    "1111".ToCharArray(),
                                    "1111".ToCharArray()
             };
            param_1 = obj.MaximalSquare(array2D);//9

        }
    }
}
