namespace LeetCode
{
    public class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int[] arr = new int[26]; // a - z lowercase

            for (int i = 0; i < magazine.Length; i++)
                arr[magazine[i] - 'a']++;

            for (int i = 0; i < ransomNote.Length; i++)
                if (--arr[ransomNote[i] - 'a'] < 0)
                    return false;

            return true;
        }
    }
}
