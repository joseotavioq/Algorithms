using Algorithms.Graph;
using Xunit;

namespace AlgorithmsTest.Graph
{
    public class MyUnweightedGraphTest
    {
        [Fact]
        public void Create_A_Graph_With_Undirected_Connections()
        {
            var graph = new MyUnweightedGraph();

            //Create all the vertex
            for (int i = 0; i <= 6; i++)
                graph.AddVertex(i);

            //Link the Vertexes
            graph.AddEdge(3, 1, TypesOfGraph.Undirected); //3 -> 1 && 1 -> 3
            graph.AddEdge(3, 4, TypesOfGraph.Undirected); //3 -> 4 && 4 -> 3
            graph.AddEdge(4, 2, TypesOfGraph.Undirected); //4 -> 2 && 2 -> 4
            graph.AddEdge(4, 5, TypesOfGraph.Undirected); //4 -> 5 && 5 -> 4
            graph.AddEdge(1, 2, TypesOfGraph.Undirected); //1 -> 2 && 2 -> 1
            graph.AddEdge(1, 0, TypesOfGraph.Undirected); //1 -> 0 && 0 -> 1
            graph.AddEdge(0, 2, TypesOfGraph.Undirected); //0 -> 2 && 2 -> 0
            graph.AddEdge(6, 5, TypesOfGraph.Undirected); //6 -> 5 && 5 -> 6

            Assert.Equal(7, graph.NumbersOfNodes);
            Assert.Equal(new int[2] { 1, 2 }, graph.GetVertex(0));
            Assert.Equal(new int[3] { 3, 2, 0 }, graph.GetVertex(1));
            Assert.Equal(new int[3] { 4, 1, 0 }, graph.GetVertex(2));
            Assert.Equal(new int[2] { 1, 4 }, graph.GetVertex(3));
            Assert.Equal(new int[3] { 3, 2, 5 }, graph.GetVertex(4));
            Assert.Equal(new int[2] { 4, 6 }, graph.GetVertex(5));
            Assert.Equal(new int[1] { 5 }, graph.GetVertex(6));
        }

        [Fact]
        public void Create_A_Graph_With_Directed_Connections()
        {
            var graph = new MyUnweightedGraph();

            //Create all the vertex
            for (int i = 0; i <= 6; i++)
                graph.AddVertex(i);

            //Link the Vertexes
            graph.AddEdge(3, 1, TypesOfGraph.Directed); //3 -> 1
            graph.AddEdge(3, 4, TypesOfGraph.Directed); //3 -> 4
            graph.AddEdge(4, 2, TypesOfGraph.Directed); //4 -> 2
            graph.AddEdge(4, 5, TypesOfGraph.Directed); //4 -> 5
            graph.AddEdge(1, 2, TypesOfGraph.Directed); //1 -> 2
            graph.AddEdge(1, 0, TypesOfGraph.Directed); //1 -> 0
            graph.AddEdge(0, 2, TypesOfGraph.Directed); //0 -> 2
            graph.AddEdge(6, 5, TypesOfGraph.Directed); //6 -> 5

            Assert.Equal(7, graph.NumbersOfNodes);
            Assert.Equal(new int[1] { 2 }, graph.GetVertex(0));
            Assert.Equal(new int[2] { 2, 0 }, graph.GetVertex(1));
            Assert.Null(graph.GetVertex(2));
            Assert.Equal(new int[2] { 1, 4 }, graph.GetVertex(3));
            Assert.Equal(new int[2] { 2, 5 }, graph.GetVertex(4));
            Assert.Null(graph.GetVertex(5));
            Assert.Equal(new int[1] { 5 }, graph.GetVertex(6));
        }
    }
}