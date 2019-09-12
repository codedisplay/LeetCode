using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Group_Anagrams
    {
        // TODO: use primeArr
        // without sort
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> list = new List<IList<string>>();
            Dictionary<string, IList<string>> lookup = new Dictionary<string, IList<string>>();
            
            Dictionary<string, string> d = new Dictionary<string, string>();

            var x = d.Values.ToList();

            for (int i = 0; i < strs.Length; i++)
            {
                int[] dic = new int[26];//a - z lowercase

                for (int j = 0; j < strs[i].Length; j++)
                    dic[strs[i][j] - 'a']++;

                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < dic.Length; j++)
                    if (dic[j] != 0)
                        sb.Append((char)(j + 'a')).Append(dic[j]);

                var str = sb.ToString();

                if (lookup.ContainsKey(str))
                    lookup[str].Add(strs[i]);
                else
                    lookup.Add(str, new List<string> { strs[i] });
            }

            return lookup.Values.ToList();
        }

        // working - by sorting each individual string
        public IList<IList<string>> GroupAnagrams1(string[] strs)
        {
            IList<IList<string>> list = new List<IList<string>>();
            Dictionary<string, IList<string>> lookup = new Dictionary<string, IList<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                var arr = strs[i].ToCharArray();
                Array.Sort(arr);
                var str = new string(arr);

                if (lookup.ContainsKey(str))
                    lookup[str].Add(strs[i]);
                else
                    lookup.Add(str, new List<string> { strs[i] });
            }

            return lookup.Values.ToList();
        }
        // TLE
        //public IList<IList<string>> GroupAnagrams(string[] strs)
        //{
        //    IList<IList<string>> list = new List<IList<string>>();
        //    Dictionary<char, int>[] lookup = new Dictionary<char, int>[strs.Length];

        //    for (int i = 0; i < strs.Length; i++)
        //    {
        //        Dictionary<char, int> dic = new Dictionary<char, int>();

        //        for (int j = 0; j < strs[i].Length; j++)
        //        {
        //            char current = strs[i][j];

        //            if (dic.ContainsKey(current))
        //                dic[current]++;
        //            else
        //                dic.Add(current, 1);
        //        }

        //        lookup[i] = dic;
        //    }

        //    bool[] used = new bool[strs.Length];

        //    for (int i = 0; i < strs.Length; i++)
        //    {
        //        if (used[i]) continue;

        //        var from = lookup[i];
        //        used[i] = true;
        //        List<string> val = new List<string>() { strs[i] };

        //        for (int j = i + 1; j < strs.Length; j++)
        //        {
        //            if (from.Count != lookup[j].Count || used[j])
        //                continue;

        //            bool isCurrentValid = true;

        //            foreach (var item in lookup[j])
        //                if (!(from.ContainsKey(item.Key) && from[item.Key] == item.Value))
        //                {
        //                    isCurrentValid = false;
        //                    continue;
        //                }

        //            if (isCurrentValid)
        //            {
        //                val.Add(strs[j]);
        //                used[j] = true;
        //            }
        //        }

        //        list.Add(val);
        //    }

        //    return list;
        //}
    }
}
