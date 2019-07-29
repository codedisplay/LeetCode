using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Reorder_Log_FilesTests
    {
        [TestMethod]
        public void ReorderLogFilesTests()
        {
            Reorder_Log_Files obj = new Reorder_Log_Files();

            var nums = new string[] { "a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo" };

            //"g1 act car","a8 act zoo","ab1 off key dog","a1 9 2 3 1","zo4 4 7"
            var x = obj.ReorderLogFiles(nums);


            nums = new string[] { "1 n u", "r 527", "j 893", "6 14", "6 82" };
            x = obj.ReorderLogFiles(nums);


            nums = new string[] { "0uoj 9", "w 8", "ry9 8231674347096 00", "k5pkn 88312912782538", "m4jl 225084707500464", "0 81650258784962331", "9h4p 5 791738 954209", "2epy 85881033085988", "43 490972281212 3 51", "16o 94884717383724 9", "ttzoz 035658365825 9", "l5sh 6 3869 08 1295" };
            x = obj.ReorderLogFiles(nums);

            nums = new string[] { "0uoj 9", "w 8", "ry9 8", "k5pkn 8", "m4jl 2", "0 8", "9h4p 5 7", "2epy 85881033085988", "43 4", "16o 9", "ttzoz 0", "l5sh 6" };
            x = obj.ReorderLogFiles(nums);

            nums = new string[] { "l5sh 6", "16o 9", "43 4", "9 ehyjki ngcoobi mi", "2epy 8", "7z fqkbxxqfks f y dg", "9h4p 5", "p i hz uubk id s m l", "wd lfqgmu pvklkdp u", "m4jl 2", "6np2 bqrrqt q vtap h", "e mpgfn bfkylg zewmg", "ttzoz 035658365825 9", "k5pkn 88312912782538", "ry9 8231674347096 00", "w 831", "bxao armngjllmvqwn q", "0uoj 9", "0 8", "t3df gjjn" };
            x = obj.ReorderLogFiles(nums);
        }
    }
}
