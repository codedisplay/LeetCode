﻿using System;

namespace LeetCode
{
    public class Class1
    {
        public static int Perform(string str)
        {
            int totalValue = 0, length = str.Length, i = 0;
            bool isCurrentAdd = true;// only two operation; add and sub// for the sub string it's add

            while (i < length)
            {
                int times = 0, maxCount = 0;

                while (str[i] == ' ')
                    i++;

                if (str[i] == '+' || str[i] == '-')
                {
                    isCurrentAdd = (str[i] == '+');
                    i++;
                }

                while (str[i] == ' ')
                    i++;

                times = str[i] - '0';//char to string conversion
                i++;

                int currentTotal = 0;

                if (i < length - 1 && str[i] == 'd')
                {// mdn format substring
                    i++;

                    maxCount = str[i] - '0';//char to string conversion
                    currentTotal = GetNumbers(times, maxCount);
                }
                else// sub string is number
                    currentTotal = times;

                if (isCurrentAdd)
                    totalValue += currentTotal;
                else
                    totalValue -= currentTotal;

                i++;
            }

            return totalValue;
        }

        public static int GetNumbers(int times, int maxCount)
        {
            int sum = 0;
            System.Random random = new System.Random();

            for (int i = 0; i < times; i++)
                sum += random.Next(0, maxCount + 1);

            return sum;
        }



        //TODO: fix logic for 0's in the middle of the num
        //var x = IsPalindrome(121);

        //x = IsPalindrome(10201);

        //x = IsPalindrome(100201);

        //x = IsPalindrome(1000201);

        //x = IsPalindrome(10002001);

        //x = IsPalindrome(1201);

        //x = IsPalindrome(int.MaxValue);
        public static bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            var count = getIntCount(x);

            //if (count == 10 && x % 1000 > 412) return false;//int max value 2,147,483,647  

            while (count > 1 && count % 2 == 0)
            {
                int p = (int)Math.Pow(10, count - 1);
                if ((x / p) != x % 10)
                    return false;

                x = x - p;

                if (x < p / 10)//left no. is zero
                {
                    if (x % 10 != 0) return false;
                    x = x / 10;
                }

                x = x - p;
                x = x / 10;
                count = count - 2;
            }

            return true;
        }

        static int getIntCount(int x)
        {
            int count = 1;

            while (x > 9)
            {
                x /= 10;
                count++;
            }

            return count;
        }
























































        ////        Input: "babad"
        ////Output: "bab"
        ////Note: "aba" is also a valid answer.

        //var x = LongestPalindrome("babad");

        ////Example 2:

        ////Input: "cbbd"
        ////Output: "bb"
        //x = LongestPalindrome("cbbd");

        //x = LongestPalindrome("");//0

        //x = LongestPalindrome("bb");
        //        x = LongestPalindrome("abb");
        public static string LongestPalindrome(string s)
        {
            if (s.Length == 0 || (s.Length == 2 && s[0] == s[1])) return s;

            string str = s.Substring(0, 1);

            for (int i = 0; i < s.Length - 2; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    if (s[i] == s[i + j])
                    {
                        var current = ExtendPalindrome(s, i, i + j);

                        if (current.Length > str.Length)
                            str = current;
                    }
                }
            }

            if (str.Length == 1 && s.Length > 2 && s[s.Length - 2] == s[s.Length - 1]) return s.Substring(s.Length - 2, 2);

            return str;
        }

        private static string ExtendPalindrome(string s, int startIndex, int endIndex)
        {
            while (true)
            {
                if (startIndex != 0 && endIndex != s.Length - 1 && s[startIndex - 1] == s[endIndex + 1])
                {
                    startIndex--;
                    endIndex++;
                }
                else
                    return s.Substring(startIndex, endIndex - startIndex + 1);
            }
        }





        //    int[] arr = new int[] { 3, 2, 1, 5, 6, 4 };
        //    var x = FindKthLargest(arr, 2);//5

        //    arr = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
        //x = FindKthLargest(arr, 4);//4
        public static int FindKthLargest(int[] nums, int k)
        {
            int[] arr = new int[k];

            for (int i = 0; i < nums.Length; i++)
            {
                if (arr[k - 1] < nums[i])
                {
                    int index = FindInsertIndex(arr, nums[i]);

                    if (index != -1)
                    {
                        int prevVal = nums[i];

                        while (index < k)
                        {
                            int temp = arr[index];
                            arr[index] = prevVal;
                            prevVal = temp;
                            index++;
                        }
                    }
                }

            }

            return arr[k - 1];
        }

        private static int FindInsertIndex(int[] arr, int val)
        {
            var l = 0;
            var r = arr.Length - 1;

            if (arr[r] <= val)
                return r;

            while (l <= r)
            {
                var mid = l + (r - l) / 2;

                if (arr[l] <= val)
                    return l;

                if (arr[mid] > val)
                    r = mid - 1;
                else
                    l = mid + 1;
            }

            return -1;
        }





        //TODO
        //string s = "leetcode";
        //string[] wordDict = new string[] { "leet", "code" };

        //var resp = WordBreak(s, wordDict);

        //s = "applepenapple";
        //wordDict = new string[] { "apple", "pen" };

        //resp = WordBreak(s, wordDict);

        //s = "catsandog";
        //wordDict = new string[] { "cats", "dog", "sand", "and", "cat" };

        //resp = WordBreak(s, wordDict);

        // var s = "aaaaaaa";
        // var wordDict = new string[] { "aaaa", "aa" };

        //var resp = WordBreak(s, wordDict);

        //public static bool WordBreak(string s, IList<string> wordDict)
        //{
        //    Node node = new Node();
        //    int i;
        //    Node currentNode;

        //    foreach (var word in wordDict)
        //    {
        //        currentNode = node;

        //        for (i = 0; i < word.Length; i++)
        //        {
        //            if (!currentNode.Children.ContainsKey(word[i]))
        //            {
        //                var newNode = new Node();
        //                currentNode.Children[word[i]] = newNode;
        //            }

        //            currentNode = currentNode.Children[word[i]];
        //        }

        //        currentNode.IsCompletedWord = true;
        //    }

        //    return WordBreakHelper(s, wordDict, 0, node);
        //}

        //private static bool WordBreakHelper(string s, IList<string> wordDict, int startIndex, Node node)
        //{
        //    int i = startIndex;
        //    Node currentNode = node;

        //    while (i < s.Length)
        //    {
        //        if (currentNode.IsCompletedWord)
        //        {
        //            if (WordBreakHelper(s, wordDict, i, node))
        //                return true;
        //        }

        //        if (currentNode.Children.ContainsKey(s[i]))
        //        {
        //            currentNode = currentNode.Children[s[i]];
        //            i++;
        //        }
        //        else
        //            return false;
        //    }

        //    return currentNode.IsCompletedWord;
        //}

        //private static bool WordBreakHelper(string s, IList<string> wordDict, int startIndex, Node node)
        //{
        //    int i = startIndex;
        //    Node currentNode = node;

        //    while (i < s.Length)
        //    {
        //        if (currentNode.IsCompletedWord)
        //        {
        //            if (WordBreakHelper(s, wordDict, i, node))
        //                return true;
        //        }

        //        if (currentNode.Children.ContainsKey(s[i]))
        //        {
        //            currentNode = currentNode.Children[s[i]];
        //            i++;
        //        }
        //        else
        //            return false;
        //    }

        //    return currentNode.IsCompletedWord;
        //}

        public static int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int i = 0;

            return i;
        }

        //public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //{

        //}


    }
}
