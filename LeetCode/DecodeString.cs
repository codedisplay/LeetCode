using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Decode_String
    {
        public string DecodeString(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return s;
            s = "1[" + s + "]";
            string result = "";
            Stack<DecodeData> stack = new Stack<DecodeData>();

            TextData currentText = new TextData();//start index and length
            int lev = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]) && s[i + 1] == '[')// valid starting of bracket
                {
                    lev++;
                    stack.Push(new DecodeData { level = lev, prefixText = currentText, startIndex = i++, times = s[i] - '0' });
                    //currentText
                }
                else if (s[i] == ']')
                {
                    lev--;
                }
                else 
                {
                    currentText.endIndex = i;
                }

                i++;
            }

            return result;
        }

    }

    public class DecodeData
    {
        public int level { get; set; }

        public TextData prefixText { get; set; }

        public int times { get; set; }

        public int startIndex { get; set; }
       
    }

    public class TextData
    {
        public int startIndex { get; set; }

        public int endIndex { get; set; }
    }
}
