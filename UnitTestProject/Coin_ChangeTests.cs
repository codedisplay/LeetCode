using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Coin_ChangeTests
    {
        [TestMethod]
        public void CoinChangeTests()
        {
            Coin_Change obj = new Coin_Change();

            var x = obj.CoinChange(new int[] { 186, 419, 83, 408 },6249);//20

            x = obj.CoinChange(new int[] { 1 }, 0);//

            x = obj.CoinChange(new int[] { 2 }, 3);//

            x = obj.CoinChange(new int[] { 5}, 5);//1

            x = obj.CoinChange(new int[] { 1, 2, 5 },4);//

            x = obj.CoinChange(new int[] { 2, 5, 10, 1 }, 27);//

            x = obj.CoinChange(new int[] { 156, 265, 40, 280 }, 9109);//
        }
    }
}
