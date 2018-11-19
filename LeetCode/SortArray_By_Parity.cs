namespace LeetCode
{
    public class SortArray_By_Parity
    {
        public int[] SortArrayByParity(int[] A)
        {
            int left = 0, right = A.Length - 1;

            while (left < right)
            {
                if (A[left] % 2 == 0)
                    left++;
                else if (A[right] % 2 != 0)
                    right--;
                else
                {
                    int temp = A[left];
                    A[left] = A[right];
                    A[right] = temp;

                    left++;
                    right--;
                }
            }

            return A;
        }
    }
}
