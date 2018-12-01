namespace LeetCode.Model.Graph
{
    public class DistanceInfo
    {
        private int distance;
        private int lastVertex;

        public DistanceInfo(int defaultDistance)
        {
            // Unweighted Graph - Defaulted to -1
            // Weighted Graph - The initial distance to all nodes is assumed infinite(Int.Max)
            distance = defaultDistance;

            lastVertex = -1;
        }

        public int GetDistance()
        {
            return distance;
        }

        public int GetLastVertex()
        {
            return lastVertex;
        }

        public void SetDistance(int distance)
        {
            this.distance = distance;
        }

        public void SetLastVertex(int lastVertex)
        {
            this.lastVertex = lastVertex;
        }
    }
}
