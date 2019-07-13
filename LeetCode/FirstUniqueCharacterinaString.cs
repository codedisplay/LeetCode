namespace LeetCode
{
    public class FirstUniqueCharacterinaString
    {
        public int FirstUniqChar(string s)
        {
            int[] lookup = new int[26];//a - z lowercase

            for (int i = 0; i < s.Length; i++)
                lookup[s[i] - 'a']++;

            for (int i = 0; i < s.Length; i++)
            {
                if (lookup[s[i] - 'a'] == 1)
                    return i;
            }
           
            return -1;
        }
    }
}
