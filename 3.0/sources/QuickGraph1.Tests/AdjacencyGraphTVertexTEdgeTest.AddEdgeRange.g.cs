// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using System.Collections.Generic;
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
        public void AddEdgeRange01()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            adjacencyGraph = new AdjacencyGraph<int, Edge<int>>(false, 2);
            adjacencyGraph.EdgeCapacity = 3;
            this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, (IEnumerable<Edge<int>>)null);
        }

        [TestMethod]
        [PexRaisedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdgeRange02()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            adjacencyGraph = new AdjacencyGraph<int, Edge<int>>(false, int.MinValue);
            adjacencyGraph.EdgeCapacity = 2;
            this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, (IEnumerable<Edge<int>>)null);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AddEdgeRange03()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            adjacencyGraph = new AdjacencyGraph<int, Edge<int>>(false, 1073741824);
            adjacencyGraph.EdgeCapacity = 3;
            this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, (IEnumerable<Edge<int>>)null);
        }

        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdgeRange04()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 2, 3);
            this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, (IEnumerable<Edge<int>>)null);
        }

        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddEdgeRange05()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, int.MinValue, 2);
            this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, (IEnumerable<Edge<int>>)null);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AddEdgeRange06()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 1073741824, 3);
            this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, (IEnumerable<Edge<int>>)null);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AddEdgeRange09()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 1073741824, 3);
            this.AddEdgeRange<int, Edge<int>>(adjacencyGraph, (IEnumerable<Edge<int>>)null);
        }

    }
}
