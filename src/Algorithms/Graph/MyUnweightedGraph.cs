using System.Collections.Generic;

namespace Algorithms.Graph
{
    /// <summary>
    /// Adjacency List of
    /// Cyclic or Acyclic
    /// Unweighted
    /// and Directed or Undirected
    /// Graph
    /// </summary>
    public class MyUnweightedGraph
    {
        public int NumbersOfNodes { get { return _adjacentList.Count; } }

        private Dictionary<int, int[]> _adjacentList = new Dictionary<int, int[]>();

        public void AddVertex(int node)
        {
            _adjacentList.Add(node, null);
        }

        public void AddEdge(int node1, int node2, TypesOfGraph typeOfGraph)
        {
            //Node1 -> Node2
            addItem(node1, node2);

            //Node2 -> Node1
            if (typeOfGraph == TypesOfGraph.Undirected)
                addItem(node2, node1);
        }

        private void addItem(int node1, int node2)
        {
            int[] value = _adjacentList[node1] as int[];
            if (value == null)
            {
                _adjacentList[node1] = new int[1] { node2 };
            }
            else
            {
                var newValue = new int[value.Length + 1];

                for (int i = 0; i < value.Length; i++)
                {
                    newValue[i] = value[i];
                }

                newValue[value.Length] = node2;

                _adjacentList[node1] = newValue;
            }
        }

        public int[] GetVertex(int node)
        {
            return _adjacentList[node];
        }
    }

    public enum TypesOfGraph
    {
        Directed,
        Undirected
    }
}