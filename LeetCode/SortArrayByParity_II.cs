namespace LeetCode
{
    public class SortArrayByParity_II
    {
        public int[] SortArrayByParityII(int[] A)
        {
            int left = 0, right;

            if ((A.Length - 1) % 2 == 0)//last even
                right = (A.Length - 1) % 2 - 1;
            else
                right = A.Length - 1;

            while (left < A.Length && right >= 0)
            {
                if ((A[left] % 2 == 0))
                    left += 2;
                else if (A[right] % 2 != 0)
                    right -= 2;
                else
                {
                    var temp = A[left];
                    A[left] = A[right];
                    A[right] = temp;

                    left += 2;
                    right -= 2;
                }
            }

            return A;
        }
    }
}
