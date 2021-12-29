using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graph.MinimumSpanningTree
{
	public class Kruskals<T,TW> where T :IComparable where TW:IComparable
	{
		public List<MSTEdge<T,TW>> FindMinimumSpanningTree(IGraph<T> graph)
		{
			//listeleme
			var edges = new List<MSTEdge<T, TW>>();
			dfs(graph.ReferenceVertex,
				new HashSet<T>(),
				new Dictionary<T, HashSet<T>>(),
				edges);
			
			var heap = new Heap.BinaryHeap<MSTEdge<T,TW>>(Shared.SortDirection.Asceding);
			foreach (var edge in edges)
				heap.Add(edge);
			//kenar sıralama
			var sortedEdgeArr = new MSTEdge<T, TW>[edges.Count];
			for (int i = 0; i < edges.Count; i++)
			{
				sortedEdgeArr[i] = heap.DeleteMinMax();
			}
			//makeset-findset-union
			var disjointSet =new Set.DisjointSet<T>();
			foreach (var vertex in graph.VerticesAsEnumerable)
			{
				disjointSet.MakeSet(vertex.Key);
			}
			
			var resultEdgeList = new List<MSTEdge<T, TW>>();
			for (int i = 0; i < edges.Count; i++)
			{
				var currentEdge = sortedEdgeArr[i];
				var setA = disjointSet.FindSet(currentEdge.Source);
				var setB = disjointSet.FindSet(currentEdge.Destination);
				
				if (setA.Equals(setB))
					continue;

				resultEdgeList.Add(currentEdge);
				disjointSet.Union(setA,setB);

			}
			return resultEdgeList;
		}

		private void dfs(IGraphVertex<T> currentVertex, HashSet<T> visitedVertices, Dictionary<T, HashSet<T>> visitedEdge, List<MSTEdge<T, TW>> edges)
		{
			if (!visitedVertices.Contains(currentVertex.Key))
			{
				visitedVertices.Add(currentVertex.Key);
				foreach (var edge in currentVertex.Edges)
				{
					if(!visitedEdge.ContainsKey(currentVertex.Key)|| !visitedEdge[currentVertex.Key].Contains(edge.TargetVertexKey))
					{
						//kenar ekleme
						edges.Add(new MSTEdge<T, TW>(currentVertex.Key,
							edge.TargetVertexKey,
							edge.Weight<TW>()));
						//kenar güncelleme
						if (!visitedEdge.ContainsKey(currentVertex.Key))
						{
							visitedEdge.Add(currentVertex.Key,new HashSet<T>());
						}
						visitedEdge[currentVertex.Key].Add(edge.TargetVertexKey);
						if (!visitedEdge.ContainsKey(edge.TargetVertexKey))
						{
							visitedEdge.Add(edge.TargetVertexKey, new HashSet<T>());
						}
						visitedEdge[edge.TargetVertexKey].Add(currentVertex.Key);
						dfs(edge.TargetVertex, visitedVertices, visitedEdge, edges);
					}
				}
			}
		}
	}
}
