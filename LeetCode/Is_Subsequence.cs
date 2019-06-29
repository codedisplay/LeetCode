namespace LeetCode
{
    public class Is_Subsequence
    {
        //Example 1:
        //s = "abc", t = "ahbgdc"

        //Return true.

        //Example 2:
        //s = "axc", t = "ahbgdc"

        //Return false
        public bool IsSubsequence(string s, string t)
        {
            int iS = 0;

            for (int i = 0; i < t.Length & iS < s.Length; i++)
            {
                if (t[i] == s[iS])
                    iS++;
            }

            return iS == s.Length;
        }
    }
}
