namespace LeetCode
{
    public class ReverseWordsinaString
    {
        public string ReverseWords(string s)
        {
            char[] arr = s.Trim().ToCharArray();

            bool isFirstSpace = true;
            int validEndIndex = 0, index = 0;
            // Trim the spaces
            while (index < arr.Length)
            {
                int iStart= validEndIndex;//start index of word
                int iEnd= validEndIndex;
                // Each word
                while (index < arr.Length && arr[index] != ' ')
                {
                    arr[validEndIndex] = arr[index];
                    iEnd = validEndIndex;
                    validEndIndex++;
                    index++;
                }

                // Reverse each word
                while (iStart < iEnd)
                {
                    var temp = arr[iStart];
                    arr[iStart] = arr[iEnd];
                    arr[iEnd] = temp;
                    iStart++;
                    iEnd--;
                }

                isFirstSpace = true;

                // add first space only
                while (index < arr.Length && arr[index] == ' ')
                {
                    if (isFirstSpace)
                    {
                        arr[validEndIndex] = arr[index];
                        validEndIndex++;
                        index++;
                        isFirstSpace = false;
                    }
                    else
                        index++;
                }
            }

            int left = 0, right = validEndIndex - 1;
            // Reverse the entire string
            while (left < right)
            {
                char temp = arr[right];
                arr[right] = arr[left];
                arr[left] = temp;
                left++;
                right--;
            }

            return new string(arr).Substring(0, validEndIndex);
        }
    }
}
