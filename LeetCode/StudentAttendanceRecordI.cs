namespace LeetCode
{
    public class StudentAttendanceRecordI
    {
        public bool CheckRecord(string s)
        {
            int aCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A' && ++aCount > 1)
                    return false;
                if (s[i] == 'L' && i > 1 && s[i - 1] == 'L' && s[i - 2] == 'L')
                    return false;
            }

            return true;
        }
    }
}
