// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;
using Microsoft.Pex.Framework.Exceptions;

namespace QuickGraph
{
    public partial class AdjacencyGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdge01()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = new AdjacencyGraph<int, Edge<int>>(false, 2);
            adjacencyGraph.EdgeCapacity = 3;
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdge02()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = new AdjacencyGraph<int, Edge<int>>(false, int.MinValue);
            adjacencyGraph.EdgeCapacity = 2;
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AddEdge03()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = new AdjacencyGraph<int, Edge<int>>(false, 1073741824);
            adjacencyGraph.EdgeCapacity = 3;
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdge04()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            bool b;
            adjacencyGraph = new AdjacencyGraph<int, Edge<int>>(false, 2);
            adjacencyGraph.EdgeCapacity = 3;
            edge = new Edge<int>(5, 6);
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, edge);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdge05()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            bool b;
            adjacencyGraph = new AdjacencyGraph<int, Edge<int>>(false, int.MinValue);
            adjacencyGraph.EdgeCapacity = 3;
            edge = new Edge<int>(4, 5);
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, edge);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdge06()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 2, 3);
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdge07()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, int.MinValue, 2);
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AddEdge08()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 1073741824, 3);
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdge09()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 2, 3);
            edge = EdgeFactory.Create(5, 6);
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, edge);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdge10()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, int.MinValue, 3);
            edge = EdgeFactory.Create(4, 5);
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, edge);
        }

        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdge11()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 2, 3);
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdge12()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, int.MinValue, 2);
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AddEdge13()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 1073741824, 3);
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AddEdge16()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 1073741824, 3);
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdge14()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, -1619017984, -134289664);
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdge15()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 0, -1346371584);
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdge17()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 1, -1346371584);
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdge18()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 6, -1346371584);
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdge19()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, -591532545, -9378272);
            edge = EdgeFactory.Create(0, 3);
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, edge);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdge20()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 6, -345709576);
            edge = EdgeFactory.Create(0, 4);
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, edge);
        }

        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdge21()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 10, -1346371584);
            b = this.AddEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

    }
}
