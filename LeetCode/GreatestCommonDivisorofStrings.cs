namespace LeetCode
{
    public class GreatestCommonDivisorofStrings
    {
        public string GcdOfStrings(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
                return "";

            string maxStr = "";

            for (int i = 1; i <= str1.Length; i++)//len of prefix
            {
                if (str1.Length % i != 0 || str2.Length % i != 0)
                    continue;

                if (i > str1.Length || i > str2.Length)
                    break;

                string current = str1.Substring(0, i), compareTo;
                var isValid = true;
                int j = i;
                while (j < str1.Length)
                {
                    compareTo = str1.Substring(j, i);

                    if (current.Equals(compareTo))
                        j += i;
                    else
                    {
                        isValid = false;
                        break;
                    }
                }

                if (!isValid)
                    continue;

                j = 0;
                while (j < str2.Length)
                {
                    compareTo = str2.Substring(j, i);

                    if (current.Equals(compareTo))
                        j += i;
                    else
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    maxStr = current;
                }


            }

            return maxStr;
        }
    }
}
