namespace LeetCode
{
    public class ValidNumber
    {
        public bool IsNumber(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return false;

            bool isDigitFound = false;
            bool isDecimalFound = false;
            bool isEfound = false;
            bool isSignFound = false;

            foreach (char c in s.Trim())
            {
                if (c >= '0' && c <= '9')
                    isDigitFound = true;
                else if (!isDecimalFound && !isEfound && c.Equals('.'))
                    isDecimalFound = isSignFound = true;
                else if (!isEfound && isDigitFound && c.Equals('e'))
                {
                    isEfound = true;
                    isDigitFound = isSignFound = isDecimalFound = false;// Setting to false so that after e, as sign/digit should be seen next
                }
                else if ((c.Equals('+') || c.Equals('-')) && ((!isDigitFound && !isSignFound && !isDecimalFound)))
                    isSignFound = true;
                else
                    return false;
            }

            return isDigitFound;
        }

        //public bool IsNumber1(String s)
        //{
        //    s = s.Trim();

        //    bool pointSeen = false;
        //    bool eSeen = false;
        //    bool numberSeen = false;
        //    bool numberAfterE = true;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if ('0' <= s[i] && s[i] <= '9')
        //        {
        //            numberSeen = true;
        //            numberAfterE = true;
        //        }
        //        else if (s[i] == '.')
        //        {
        //            if (eSeen || pointSeen)
        //            {
        //                return false;
        //            }
        //            pointSeen = true;
        //        }
        //        else if (s[i] == 'e')
        //        {
        //            if (eSeen || !numberSeen)
        //            {
        //                return false;
        //            }
        //            numberAfterE = false;
        //            eSeen = true;
        //        }
        //        else if (s[i] == '-' || s[i] == '+')
        //        {
        //            if (i != 0 && s[i - 1] != 'e')
        //            {
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }

        //    return numberSeen && numberAfterE;
        //}
    }
}
