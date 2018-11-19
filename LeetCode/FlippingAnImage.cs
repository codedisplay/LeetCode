namespace LeetCode
{
    public class FlippingAnImage
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            int left, right;

            for (int i = 0; i < A.Length; i++)
            {
                left = 0;
                right = A[0].Length - 1;

                while (left < right)
                {
                    var temp = A[i][left];
                    A[i][left] = 1 - A[i][right];
                    A[i][right] = 1 - temp;
                    left++;
                    right--;
                }

                if (left == right)
                    A[i][left] = 1 - A[i][left];
            }

            return A;
        }
    }
}
