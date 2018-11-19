namespace LeetCode
{
    public class KthSmallestElementInASortedMatrix
    {
        public int KthSmallest(int[,] matrix, int k)
        {
            if (matrix.Length == 0) return 0;

            int rows = matrix.GetLength(0) - 1;
            int cols = matrix.Length / matrix.GetLength(0) - 1;

            int[] arr = new int[rows + 1];
            int currentLowest = 0;
            int currentLowestIndex = 0;

            int i = 0;

            while (i < k)// search number
            {
                currentLowest = int.MaxValue;
                currentLowestIndex = -1;

                for (int index = 0; index <= rows; index++)// iterate each row
                {
                    if (arr[index] <= cols)
                    {
                        if (matrix[index, arr[index]] < currentLowest)
                        {
                            currentLowest = matrix[index, arr[index]];
                            currentLowestIndex = index;
                        }
                    }
                }

                arr[currentLowestIndex]++;
                i++;
            }

            return currentLowest;
        }
    }
}
