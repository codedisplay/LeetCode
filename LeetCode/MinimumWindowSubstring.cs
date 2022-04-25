namespace LeetCode
{
    public class MinimumWindowSubstring
    {
        public string MinWindow(string s, string t)
        {
            if (s.Length < t.Length)
                return string.Empty;

            int[] sCountArr = new int[128], tCountArr = new int[128];
            int l = 0, minL = 0;
            int minLen = 0, totalTLen = t.Length, matchedSLen = 0;
            int i;

            for (i = 0; i < t.Length; i++)
                tCountArr[t[i] - '0']++;

            for (i = 0; i < s.Length; i++)
            {
                var curr = s[i] - '0';

                if (tCountArr[curr] > 0)
                {
                    if (sCountArr[curr] < tCountArr[curr])
                    {
                        sCountArr[curr]++;
                        matchedSLen++;
                    }
                    else
                        sCountArr[curr]++;

                    if (matchedSLen == totalTLen)
                    {
                        while (l < s.Length)
                        {
                            var c = s[l] - '0';

                            if (sCountArr[c] == 0)
                                l++;
                            else if (sCountArr[c] > tCountArr[c])
                            {
                                sCountArr[c]--;
                                l++;
                            }
                            else
                                break;
                        }

                        if (minLen == 0 || minLen >= (i - l + 1))
                        {
                            minL = l;
                            minLen = (i - l + 1);
                        }

                        sCountArr[s[l] - '0']--;
                        matchedSLen--;
                        l++;
                    }
                }
            }

            return s.Substring(minL, minLen);
        }

        //public string MinWindow(string s, string t)
        //{
        //    if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length < t.Length)
        //        return string.Empty;

        //    int currentFound = 0, minStart = 0, minLength = int.MaxValue, currentStart = -1, currentLength = 0;
        //    Dictionary<char, Queue<int>> dic = new Dictionary<char, Queue<int>>();

        //    for (int i = 0; i < t.Length; i++)
        //    {
        //        if (dic.ContainsKey(t[i]))
        //            dic[t[i]].Enqueue(-1);
        //        else
        //            dic.Add(t[i], new Queue<int>(new[] { -1 }));
        //    }

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (dic.ContainsKey(s[i]))
        //        {
        //            var currentQueue = dic[s[i]];
        //            var prevVal = currentQueue.Dequeue();

        //            if (prevVal == -1)
        //            {
        //                currentFound++;

        //                if (currentStart == -1)
        //                    currentStart = i;
        //            }

        //            currentQueue.Enqueue(i);

        //            if (prevVal == currentStart)
        //            {
        //                int j = prevVal + 1;
        //                while (j <= i && (!dic.ContainsKey(s[j]) || !dic[s[j]].Contains(j)))
        //                    j++;

        //                currentStart = j;
        //            }

        //            if (currentFound == t.Length)
        //            {
        //                currentLength = i - currentStart + 1;

        //                if (currentLength < minLength)
        //                {
        //                    minStart = currentStart;
        //                    minLength = currentLength;
        //                }
        //            }

        //        }
        //    }

        //    return currentFound == t.Length ? s.Substring(minStart, minLength) : string.Empty;
        //}


    }
}