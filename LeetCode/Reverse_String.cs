namespace LeetCode
{
    public class Reverse_String
    {
        public string ReverseString(string s)
        {
            var arr = s.ToCharArray();
            int left = 0, right = s.Length - 1;

            while (left < right)
            {
                var temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }

            return new string(arr);
        }
    }
}
