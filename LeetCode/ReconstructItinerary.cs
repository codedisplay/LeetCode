using System.Collections.Generic;

namespace LeetCode
{
    public class ReconstructItinerary
    {
        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            Dictionary<string, List<KeyValuePair<int, string>>> dic = new Dictionary<string, List<KeyValuePair<int, string>>>();
            HashSet<int> seq = new HashSet<int>();
            int index = 0;

            foreach (var ticket in tickets)
            {
                if (dic.ContainsKey(ticket[0]))
                    dic[ticket[0]].Add(new KeyValuePair<int, string>(index, ticket[1]));
                else
                    dic.Add(ticket[0], new List<KeyValuePair<int, string>> { new KeyValuePair<int, string>(index, ticket[1]) });
                index++;
            }

            // Sort all the dictionary values
            foreach (var item in dic)
                item.Value.Sort((x, y) => { return x.Value.CompareTo(y.Value); });

            DFS(tickets, 0, ref seq, "JFK", dic);

            List<string> final = new List<string>() { "JFK" };
            foreach (var i in seq)
                final.Add(tickets[i][1]);

            return final;
        }

        private bool DFS(IList<IList<string>> tickets, int processed, ref HashSet<int> seq, string current,
            Dictionary<string, List<KeyValuePair<int, string>>> dic)
        {
            if (processed == tickets.Count)
                return true;
            else if (!dic.ContainsKey(current))
                return false;

            var nextArr = dic[current];
            var isFound = false;

            foreach (var next in nextArr)
            {
                if (seq.Contains(next.Key))
                    continue;

                seq.Add(next.Key);
                isFound = DFS(tickets, processed + 1, ref seq, next.Value, dic);
                if (!isFound)
                    seq.Remove(next.Key);
                else
                    return true;
            }

            return isFound;
        }
    }
}
