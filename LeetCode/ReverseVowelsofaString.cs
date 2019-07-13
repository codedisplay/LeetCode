using System.Collections.Generic;

namespace LeetCode
{
    public class ReverseVowelsofaString
    {
        public string ReverseVowels(string s)
        {
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var arr = s.ToCharArray();

            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                while (left < right && !vowels.Contains(arr[left]))
                    left++;

                while (left < right && !vowels.Contains(arr[right]))
                    right--;

                if (left < right)
                {
                    var temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }

            return new string(arr);
        }
    }
}
