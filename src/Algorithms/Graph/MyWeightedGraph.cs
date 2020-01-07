using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Graph
{
    /// <summary>
    /// Adjacency List of
    /// Cyclic or Acyclic
    /// Weighted
    /// and Directed or Undirected
    /// Graph
    /// </summary>
    public class MyWeightedGraph
    {
        public int NumbersOfNodes { get { return _adjacentList.Count; } }

        private List<GraphNode> _adjacentList = new List<GraphNode>();

        public void AddVertex(int node)
        {
            _adjacentList.Add(new GraphNode(node));
        }

        public void AddEdge(int node1, int node2, int weight, TypesOfGraph typeOfGraph)
        {
            //Node1 -> Node2
            _adjacentList[node1].AddChildren(node2, weight);

            //Node2 -> Node1
            if (typeOfGraph == TypesOfGraph.Undirected)
                _adjacentList[node2].AddChildren(node1, weight);
        }

        public int[] GetVertex(int node)
        {
            var children = _adjacentList[node].Children;

            if (children.Count == 0)
                return null;

            int[] vertexes = new int[children.Count];

            for (int i = 0; i < children.Count; i++)
            {
                vertexes[i] = children[i].Item;
            }

            return vertexes;
        }

        public int GetWeight(int node1, int node2)
        {
            return _adjacentList[node1].Children.Single(c => c.Item == node2).Weight;
        }
    }

    public class GraphNode
    {
        public int Item { get; private set; }
        public int Weight { get; private set; }
        public List<GraphNode> Children { get; private set; }

        public GraphNode(int item)
        {
            Item = item;
            Children = new List<GraphNode>();
        }

        public GraphNode(int item, int weight) : this(item)
        {
            Weight = weight;
        }

        public void AddChildren(int Item, int weight)
        {
            Children.Add(new GraphNode(Item, weight));
        }
    }
}