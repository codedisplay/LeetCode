using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MinimumNumberofFrogsCroaking
    {
        //All characters in the string are: 'c', 'r', 'o', 'a' or 'k'.
        public int MinNumberOfFrogs(string croakOfFrogs)
        {
            int noOfFrogs = -1;

            List<bool> cList = new List<bool>();
            List<bool> rList = new List<bool>();
            List<bool> oList = new List<bool>();
            List<bool> aList = new List<bool>();
            List<bool> kList = new List<bool>();

            foreach (var c in croakOfFrogs)
            {
                switch (c)
                {
                    case 'c':
                        cList.Add(true);
                        noOfFrogs = Math.Max(noOfFrogs,cList.Count);
                        break;
                    case 'r':
                        if (cList.Count == rList.Count) return -1;
                        rList.Add(true);
                        break;
                    case 'o':
                        if (rList.Count == oList.Count) return -1;
                        oList.Add(true);
                        break;
                    case 'a':
                        if (oList.Count == aList.Count) return -1;
                        aList.Add(true);
                        break;
                    case 'k':
                        if (aList.Count == kList.Count) return -1;
                        cList.Remove(true);
                        rList.Remove(true);
                        oList.Remove(true);
                        aList.Remove(true);
                        break;
                    default:
                        return -1;
                }
            }

            return cList.Count == 0 ? noOfFrogs : -1;
        }
    }
}
