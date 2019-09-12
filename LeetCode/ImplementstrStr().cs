namespace LeetCode
{
    public class ImplementstrStr__
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack.Length < needle.Length)
                return -1;
            if (needle.Length == 0)
                return 0;

            int index = -1;
            int positon = 0;

            for (int i = 0; i < needle.Length; i++)
            {
                if (haystack[i] == needle[positon])
                    positon++;
                //if()
                //else
                //    positon = 0;
            }

            //int[] cur
            
            return index;
        }
    }
}
