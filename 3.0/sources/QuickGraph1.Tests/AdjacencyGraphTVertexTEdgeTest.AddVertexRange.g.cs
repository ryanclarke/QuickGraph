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
using Microsoft.Pex.Framework.Exceptions;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph
{
    public partial class AdjacencyGraphTVertexTEdgeTest
    {
        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVertexRange01()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 2, 3);
            this.AddVertexRange<int, Edge<int>>(adjacencyGraph, (IEnumerable<int>)null);
        }

        [TestMethod]
        [ExpectedException(typeof(TraceAssertionException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVertexRange02()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, int.MinValue, 2);
            this.AddVertexRange<int, Edge<int>>(adjacencyGraph, (IEnumerable<int>)null);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AddVertexRange03()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 1073741824, 3);
            this.AddVertexRange<int, Edge<int>>(adjacencyGraph, (IEnumerable<int>)null);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AddVertexRange06()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            adjacencyGraph = AdjacencyGraphFactory.Create(false, 1073741824, 3);
            this.AddVertexRange<int, Edge<int>>(adjacencyGraph, (IEnumerable<int>)null);
        }

    }
}
