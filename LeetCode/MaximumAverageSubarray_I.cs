namespace LeetCode
{
    public class MaximumAverageSubarray_I
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            double maxSum = 0;

            for (int i = 0; i < k; i++)
                maxSum += nums[i];

            double currentSum = maxSum;

            for (int i = k; i < nums.Length; i++)
            {
                currentSum = currentSum - nums[i - k] + nums[i];

                if (currentSum > maxSum)
                    maxSum = currentSum;
            }

            return maxSum / k;
        }

        // Time exceeded exception
        //public double FindMaxAverage1(int[] nums, int k)
        //{
        //    double maxSum = 0;

        //    for (int i = 0; i <= nums.Length - k; i++)
        //    {
        //        double currentSum = 0;

        //        for (int j = i; j < k + i; j++)
        //            currentSum += nums[j];

        //        if (i == 0 || currentSum > maxSum)
        //            maxSum = currentSum;
        //    }

        //    return maxSum / k;
        //}
    }
}
