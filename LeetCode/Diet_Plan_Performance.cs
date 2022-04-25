using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Diet_Plan_Performance
    {
        public int DietPlanPerformance(int[] calories, int k, int lower, int upper)
        {
            int points = 0;
            int currSum = 0;
            int i;

            for (i = 0; i < k; i++)
            {
                currSum += calories[i];
            }

            if (currSum < lower) points += -1;
            else if (upper < currSum) points += 1;

            i = 0;
            while (i + k < calories.Length)
            {
                currSum = currSum - calories[i];
                currSum = currSum + calories[i + k];

                if (currSum < lower) points += -1;
                else if (upper < currSum) points += 1;
                i++;
            }

            return points;
        }
    }
}
