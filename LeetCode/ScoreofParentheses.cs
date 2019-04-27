using System.Collections.Generic;

namespace LeetCode
{
    public class Score_of_Parentheses
    {
        public int ScoreOfParentheses(string S)
        {
            char[] arr = S.ToCharArray();
            Stack<ScoreData> stack = new Stack<ScoreData>();
            ScoreData prev = new ScoreData(0, 0);

            int level = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '(')
                {
                    level++;
                    stack.Push(new ScoreData(level, 0));
                }
                else
                {
                    prev = stack.Pop();

                    if (prev.Level == level)
                        prev = new ScoreData(level, 1 + prev.Value);
                    else
                    {
                        var current = stack.Pop();

                        do
                        {
                            if (current.Level < level)
                            {
                                stack.Push(current);
                                break;
                            }
                            else if (prev.Level > current.Level)
                                prev = new ScoreData(current.Level, current.Value + 2 * prev.Value);
                            else if (prev.Level == current.Level)
                                prev = new ScoreData(current.Level, prev.Value + current.Value);

                            if (stack.Count == 0)
                                current = null;
                            else
                                current = stack.Pop();
                        } while (current != null);
                    }

                    stack.Push(prev);
                    level--;
                }
            }

            int sum = 0;

            while (stack.Count > 0)
                sum += stack.Pop().Value;

            return sum;
        }

        public class ScoreData
        {
            public ScoreData(int level, int score)
            {
                Level = level;
                Value = score;
            }

            public int Value { get; set; }
            public int Level { get; set; }
        }

        //public int ScoreOfParentheses(string S)
        //{
        //    char[] arr = S.ToCharArray();
        //    int count = 0;
        //    int level = 0;
        //    Stack<ScoreData> stack = new Stack<ScoreData>();
        //    int current = 1;

        //    Dictionary<int, int> dic = new Dictionary<int, int>();
        //    dic.Add(0,0);

        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        ScoreData data = new ScoreData { Sibling = 0, Children = 0 };

        //        if (arr[i] == '(')
        //        {

        //            level++;
        //            if (!dic.ContainsKey(level))
        //                dic[level] = 0;
        //           else if (dic.ContainsKey(level + 1))
        //                dic[level + 1] = 0;


        //                stack.Push(data);
        //        }
        //        else// if (arr[current] == ')')
        //        {
        //            if (arr[i - 1] == '(')
        //            {
        //                dic[level] = 1 + dic[level];
        //                current = dic[level];
        //            }
        //            else
        //            {
        //                dic[level] = 2 * current;
        //                current = dic[level];
        //            }

        //            level--;
        //            //ScoreData prev = stack.Pop();
        //            //current = current + prev.Children;
        //        }
        //    }

        //    return current;
        //}

        //public class ScoreData
        //{
        //    public int Sibling { get; set; }
        //    public int Children { get; set; }
        //}
        ////////////////////////////////
        //public int ScoreOfParentheses(string S)
        //{
        //    //char[] arr = S.ToCharArray();

        //    //int count = Perform(0, arr.Length - 1, arr);

        //    //return count;
        //}

        //private int Perform(int start, int end, char[] arr)
        //{
        //    int current = start;
        //    Stack<int> left = new Stack<int>();

        //    char lastVal = '(';

        //    while (left.Count != 0 && current < arr.Length)
        //    {
        //        if (arr[current] == '(')
        //        {
        //            left.Push(current);
        //        }
        //        else// if (arr[current] == ')')
        //        {
        //            if (lastVal == '(')
        //            {

        //            }
        //        }

        //        lastVal = arr[current];
        //        current++;
        //    }
        //}

        //private int Count(int start, int end, char[] arr)
        //{
        //    if (start > end)
        //        return 0;

        //    int rightCount = 0;
        //    int right = end - 1;

        //    while (right >= start && arr[right] == '(' && arr[end] == ')')
        //    {
        //        rightCount++;
        //        right = right - 2;
        //        end = end - 2;
        //    }

        //    if (right <= start)
        //        return rightCount;

        //    int leftCount = 0;
        //    int left = start + 1;

        //    while (left <= end && arr[start] == '(' && arr[left] == ')')
        //    {
        //        leftCount++;
        //        start = start + 2;
        //        left = left + 2;
        //    }

        //    int nestedCount = 0;


        //    while (arr[left] == '(' && arr[end] == ')')
        //    {
        //        if (left == end - 1)
        //            nestedCount = 1;
        //        else
        //            nestedCount = 2 * Count(left, end - 1, arr);
        //    }

        //    return leftCount + nestedCount + rightCount;
        //}
    }
}
