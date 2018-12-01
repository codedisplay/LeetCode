using System;
using System.Collections.Generic;

namespace LeetCode.Model
{
    public enum GraphType
    {
        DIRECTED,
        UNDIRECTED
    }

    public interface IGraph
    {
        GraphType TypeofGraph();

        void AddEdge(int v1, int v2);

        void AddEdge(int v1, int v2, int weight);

        int GetWeightedEdge(int v1, int v2);

        List<int> GetAdjacentVertices(int v);

        int GetNumVertices();

        int GetIndegree(int v);
    }

    public class AdjacencyMatrixGraph : IGraph
    {
        private int[,] adjacencyMatrix;
        private GraphType graphType = GraphType.DIRECTED;
        private readonly int numVertices = 0;

        public AdjacencyMatrixGraph(int numVertices, GraphType graphType)
        {
            this.graphType = graphType;
            this.numVertices = numVertices;
            adjacencyMatrix = new int[numVertices, numVertices];

            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    adjacencyMatrix[i, j] = 0;
                }
            }
        }

        public GraphType TypeofGraph()
        {
            return graphType;
        }

        public void AddEdge(int v1, int v2)
        {
            AddEdge(v1, v2, 1); // for un-weighted graph by default weight is 1
        }

        public void AddEdge(int v1, int v2, int weight)
        {
            if (v1 >= numVertices || v2 >= numVertices || v1 < 0 || v2 < 0)
            {
                throw new Exception("Vertex number is not valid");
            }

            adjacencyMatrix[v1, v2] = weight;

            if (graphType == GraphType.UNDIRECTED)
            {
                adjacencyMatrix[v2, v1] = weight;
            }
        }

        public int GetWeightedEdge(int v1, int v2)
        {
            return adjacencyMatrix[v1, v2];
        }

        public List<int> GetAdjacentVertices(int v)
        {
            if (v < 0 || v >= numVertices)
            {
                throw new Exception("Vertex number is not valid");
            }

            List<int> integerList = new List<int>();

            for (int i = 0; i < numVertices; i++)
            {
                if (adjacencyMatrix[v, i] != 0)
                {
                    integerList.Add(i);
                }
            }

            return integerList;
        }

        public int GetIndegree(int v)
        {
            if (v < 0 || v >= numVertices)
            {
                throw new Exception("Vertex number is not valid");
            }

            int indegree = 0;

            for (int i = 0; i < GetNumVertices(); i++)
            {
                if (adjacencyMatrix[i, v] != 0)
                {
                    indegree++;
                }
            }

            return indegree;
        }

        public int GetNumVertices()
        {
            return numVertices;
        }
    }
}
