namespace LeetCode
{
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string J, string S)
        {
            int jewelCount = 0;

            foreach (char stone in S)
                foreach (char jewel in J)
                    if (stone.Equals(jewel))
                    {
                        jewelCount++;
                        break;
                    }

            return jewelCount;
        }
    }
}
