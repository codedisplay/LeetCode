using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class StudentAttendanceRecordITests
    {
        [TestMethod]
        public void CheckRecordTests()
        {
            StudentAttendanceRecordI obj = new StudentAttendanceRecordI();

            var x = obj.CheckRecord("LALL");//true

            x = obj.CheckRecord("PPALLP");//t

            x = obj.CheckRecord("PPALLL");//f
        }
    }
}