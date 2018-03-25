namespace LeetCode
{
    public class RangeAddition
    {
        public int[] GetModifiedArray(int length, int[,] updates)
        {
            int[] arr = new int[length];

            for (int i = 0, x = 0; updates.Length != 0 & i <= updates.Length; 
                x++, i = (i == 0 ? 3 : i * 3))
            {
                int strtIndex = updates[x, 0];
                int endIndex = updates[x, 1];

                for (int j = strtIndex; j <= endIndex; j++)
                {
                    arr[j] += updates[x, 2];
                }
            }

            return arr;
        }

    
    }
}
