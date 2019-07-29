using System.Collections.Generic;

namespace LeetCode
{
    public class Unique_Email_Addresses
    {
        public int NumUniqueEmails(string[] emails)
        {
            int count = 0;
            HashSet<string> processed = new HashSet<string>();

            for (int i = 0; i < emails.Length; i++)
            {
                var @index = emails[i].IndexOf("@");
                var current = emails[i].Substring(0, @index);

                int plusIndex = current.IndexOf("+");
                if (plusIndex > -1)
                    current = current.Substring(0, plusIndex);

                current = current.Replace(".", "") + emails[i].Substring(@index);

                processed.Add(current);
            }

            return processed.Count;
        }
    }
}
