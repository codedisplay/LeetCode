namespace LeetCode
{
    public class PeakIndexInAMountaInArray
    {

        public int PeakIndexInMountainArray(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] > A[i + 1])
                    return i;
            }

            return A.Length - 1;
        }

    }
}
