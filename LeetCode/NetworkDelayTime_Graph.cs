using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class NetworkDelayTime_Graph
    {
        private class DistanceInfo
        {
            public int distance;
            public int lastVertex;

            public DistanceInfo(int defaultDistance)
            {
                distance = defaultDistance;
                lastVertex = -1;
            }
        }

        public int NetworkDelayTime(int[,] times, int N, int K)
        {
            int delayTime = -1;
            Dictionary<int, DistanceInfo> distanceTable = new Dictionary<int, DistanceInfo>();

            //Initialize Distance Table
            //for (int i = 0; i < (times.Length / 3); i++)
            //{

            //} 

            var resp = Dijkstra(times,K,N);

            return delayTime;
        }

        private static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < verticesCount; ++v)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        public int[] Dijkstra(int[,] graph, int source, int verticesCount)
        {
            int[] distance = new int[verticesCount];
            bool[] shortestPathTreeSet = new bool[verticesCount];

            for (int i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
                shortestPathTreeSet[u] = true;

                for (int v = 0; v < verticesCount; ++v)
                    if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                        distance[v] = distance[u] + graph[u, v];
            }

            return distance;
        }

        //public int NetworkDelayTime(int[,] times, int N, int K)
        //{
        //    int delayTime = -1;
        //    Dictionary<int, Dictionary<int, int>> graph = new Dictionary<int, Dictionary<int, int>>();//value- adjacent vertices with distances
        //    Dictionary<int, int> distanceInfoes = new Dictionary<int, int>();

        //    //Construct Graph
        //    for (int i = 0; i < (times.Length / 3); i++)
        //    {
        //        if (!graph.ContainsKey(times[i, 0]))
        //            graph.Add(times[i, 0], new Dictionary<int, int>());

        //        var dic = graph[times[i, 0]];
        //        dic.Add(times[i, 1], times[i, 2]);
        //        graph[times[i, 0]] = dic;

        //        if (!distanceInfoes.ContainsKey(times[i, 0]))
        //            distanceInfoes.Add(times[i, 0], -1);// for new value default distance is -1, as there are no -ve distances
        //        if (!distanceInfoes.ContainsKey(times[i, 1]))
        //            distanceInfoes.Add(times[i, 1], -1);// for new value default distance is -1, as there are no -ve distances
        //    }

        //    distanceInfoes[K] = 0;

        //    //Find max distance to from source to any node
        //    BuildDistanceTable(graph, distanceInfoes, K, 0, ref delayTime);

        //    int val= distanceInfoes.Max(d => d.Value);
        //    return val > 0 ? val : -1;
        //}

        //private bool BuildDistanceTable(Dictionary<int, Dictionary<int, int>> graph, Dictionary<int, int> distancesDictionary, int source, int currentVal, ref int maxVal)
        //{
        //    Dictionary<int, int> distanceInfo = new Dictionary<int, int>();
        //    var adjacentVertexInfoes = graph.ContainsKey(source) ? graph[source] : null;

        //    if (!(adjacentVertexInfoes?.Count > 0))
        //        return true;

        //    foreach (var adjacentVertexInfo in adjacentVertexInfoes)
        //    {
        //        var distance = adjacentVertexInfo.Value;

        //        if (distancesDictionary.ContainsKey(adjacentVertexInfo.Key) && distancesDictionary[adjacentVertexInfo.Key] != -1 &&
        //            distancesDictionary[adjacentVertexInfo.Key] < currentVal + distance)
        //            return true;

        //        distancesDictionary[adjacentVertexInfo.Key] = currentVal + distance;
        //        maxVal = System.Math.Max(maxVal, currentVal + distance);

        //        var response = BuildDistanceTable(graph, distancesDictionary, adjacentVertexInfo.Key, currentVal + distance, ref maxVal);
        //        if (response == false)
        //            return false;
        //    }

        //    return true;
        //}
    }
}
