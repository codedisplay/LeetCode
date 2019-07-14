namespace LeetCode
{
    public class Searcha2DMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix.Length == 0 || matrix[0].Length == 0)
                return false;

            int m = matrix.Length, n = matrix[0].Length;
            int start = 0, end = m * n - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                int midRow = mid / n;
                int midCol = mid % n;

                if (matrix[midRow][midCol] == target)
                    return true;
                else
                {
                    if (target < matrix[midRow][midCol])
                        end = mid - 1;
                    else
                        start = mid + 1;
                }
            }

            return false;
        }
    }
}
