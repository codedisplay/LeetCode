namespace LeetCode
{
    public class FindAnagramMappings
    {
        public int[] AnagramMappings(int[] A, int[] B)
        {
            if (A.Length != B.Length)
                return new int[0];

            int[] mappingsArr = new int[A.Length];

            int index = 0;

            foreach (int a in A)
            {
                mappingsArr[index] = System.Array.IndexOf(B, a);
                index++;
            }

            return mappingsArr;
        }
    }
}
