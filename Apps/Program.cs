//using DataStructures.LinkedList.DoubleLinkedList;
//using DataStructures.LinkedList.SingleLinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DataStructures.Stack;
using DataStructures.Queue;
using DataStructures._Tree.BST;
using DataStructures._Tree.BinaryTree;

namespace Apps
{
	class Program
	{

		static void Main(string[] args)
		{
			var arr = new sbyte[] { 16, 23, 44, 12, 55, 40, 6 };
			foreach (var item in arr)
			{
				Console.Write($"{ item,-5}");
			}
			Console.WriteLine();
			var heap = new DataStructures.Heap.MinHeap<sbyte>(arr);
			foreach (var item in heap)
			{
				Console.Write($"{heap.DeleteMinMax(),-5}");
			}
			

			Console.ReadKey();
		}
		/*private static void MergeSort()
		{
			var arr = new sbyte[] { 16, 23, 44, 12, 55, 40, 6 };
			foreach (var item in arr)
			{
				Console.Write($"{ item,-5}");
			}
			Console.WriteLine();
			DataStructures.SortingAlgorithms.MergeSort.Sort<sbyte>(arr);
			foreach (var item in arr)
			{
				Console.Write($"{ item,-5}");
			}
			Console.ReadKey();
		}
		private static void QuickSort()
		{
			var arr = new int[] { 16, 23, 44, 12, 55, 40, 6 };
			foreach (var item in arr)
			{
				Console.Write($"{ item,-5}");
			}
			Console.WriteLine();
			DataStructures.SortingAlgorithms.QuickSort.Sort<int>(arr);
			foreach (var item in arr)
			{
				Console.Write($"{ item,-5}");
			}
			Console.ReadKey();

		}
		private static void InsertionSort()
			{
				var arr = new int[] { 16, 23, 44, 12, 55, 40, 6 };
			foreach (var item in arr)
			{
				Console.Write($"{ item,-5}");
			}
			Console.WriteLine();
			DataStructures.SortingAlgorithms.InsertionSort.Sort<int>(arr, DataStructures.Shared.SortDirection.Descending);
			foreach (var item in arr)
			{
				Console.Write($"{ item,-5}");
			}
			DataStructures.SortingAlgorithms.InsertionSort.Sort<int>(arr);
			Console.WriteLine();
			foreach (var item in arr)
			{
				Console.Write($"{ item,-5}");
			}
			Console.ReadKey();
		}
			private static void BubbleSort()
			{
				var arr = new int[] { 16, 23, 44, 12, 55, 40, 6 };
			foreach (var item in arr)
			{
				Console.Write($"{ item,-5}");
			}
			Console.WriteLine();
			DataStructures.SortingAlgorithms.BubbleSort.Sort<int>(arr);
			foreach (var item in arr)
			{
				Console.Write($"{ item,-5}");
			}
			Console.ReadKey();
		}
		private static void SelectionSorting() { 
			var arr = new int[] { 16, 23, 44, 12, 55, 40, 6 };
			foreach (var item in arr)
			{
				Console.Write($"{ item,-5}");
			}
			Console.WriteLine();
			DataStructures.SortingAlgorithms.SelectionSort.Sort<int>(arr,DataStructures.Shared.SortDirection.Descending);
			foreach (var item in arr)
			{
				Console.Write($"{ item,-5}");
			}

			Console.WriteLine();
			DataStructures.SortingAlgorithms.SelectionSort.Sort<int>(arr, DataStructures.Shared.SortDirection.Asceding);
			foreach (var item in arr)
			{
				Console.Write($"{ item,-5}");
			}
			Console.ReadKey();
		}
			private static void MinimmumSpanningTree()
			{ 
			var graph = new DataStructures
				.Graph
				.AdjancencySet
				.WeightedGraph<int,int>();
			for (int i = 0; i <=11; i++)
			{
				graph.AddVertex(i);
			}
			graph.AddEdge(0,1,4);
			graph.AddEdge(0,7,8);
			graph.AddEdge(1,7,11);
			graph.AddEdge(1,2,8);
			graph.AddEdge(7,8,7);
			graph.AddEdge(7,6,1);
			graph.AddEdge(6,8,6);
			graph.AddEdge(2,8,2);
			graph.AddEdge(2,3,7);
			graph.AddEdge(2,5,4);
			graph.AddEdge(6,5,2);
			graph.AddEdge(5,3,14);
			graph.AddEdge(5,4,10);
			graph.AddEdge(3, 4, 9);

			var algorithm = new DataStructures
				.Graph
				.MinimumSpanningTree
				.Kruskals<int, int>();

			algorithm.FindMinimumSpanningTree(graph)
				.ForEach(edge=>Console.WriteLine(edge));

			var algorithm = new DataStructures//prims algoritması
				.Graph
				.MinimumSpanningTree
				.Prims<int, int>();

			algorithm.FindMinimumSpanningTree(graph)//List<MSTEdge<T,TW>> geri döndürür
				.ForEach(edge => Console.WriteLine(edge));

			var algorithm = new DataStructures
				.Graph
				.Search
				.BreadthFirst<int>();
			Console.WriteLine(algoritm.Find(graph, 23) );//BreadthFirst Algoritması
			var algoritm = new DataStructures
				.Graph
				.Search
				.DepthFirst<int>();

			Console.WriteLine("{0}",algoritm.Find(graph,100)?"Yes.":"No!");//DepthFirst Algoritması

			Console.ReadKey(); 
		}
		private static void WeightedDiGraph() { 
			var graph = new DataStructures
				.Graph
				.AdjancencySet
				.WeightedDiGraph<char, int>(new char[] {'A','B','C','D','E' });
			Console.WriteLine($"Number of vertex in this graph:{graph.Count}");

			Console.WriteLine("Is an edge between A and B? {0}",graph.HasEdge('A','B') ? "Yes." : "No!");
			Console.WriteLine("Is an edge between B and A? {0}", graph.HasEdge('B', 'A') ? "Yes." : "No!");

			graph.AddEdge('A','C',12);
			graph.AddEdge('A', 'D', 60);
			graph.AddEdge('B', 'A', 10);
			graph.AddEdge('C', 'D', 32);
			graph.AddEdge('C', 'B', 20);
			graph.AddEdge('E', 'A', 7);

			foreach (var vertexKey in graph)
			{
				Console.WriteLine(vertexKey);
				foreach (char key in graph.GetVertex(vertexKey))
				{
					var nodeU = graph.GetVertex(vertexKey);
					var nodeV = graph.GetVertex(key);
					var w = nodeU.GetEdge(nodeV).Weight<int>();
					Console.WriteLine($"   {vertexKey} - " +
					 $"({w}) - " +
					 $"{key}");
				}
			}
			Console.ReadKey();
		}
		private static void DiGraph() 
		{ 
			var graph = new DataStructures
				.Graph
				.AdjancencySet
				.DiGraph<char>(new char[] { 'A', 'B', 'C', 'D' ,'E'});

			graph.AddEdge('B', 'A');
			graph.AddEdge('A', 'D');
			graph.AddEdge('D', 'E');
			graph.AddEdge('C', 'D');
			graph.AddEdge('C', 'E');
			graph.AddEdge('C', 'A');
			graph.AddEdge('C', 'B');

			Console.WriteLine("Is there an edge between A and B? {0}", graph.HasEdge('A','B')? "Yes." : "No!");
			Console.WriteLine("Is there an edge between B and A? {0}", graph.HasEdge('B','A')? "Yes." : "No!");
			graph.RemoveVertex('C');
			foreach (var key in graph)
			{
				Console.WriteLine(key);
				foreach (char item in graph.GetVertex(key))
				{
					Console.WriteLine($"   {item}");
				}
			}
			Console.WriteLine($"Number of vertex in the graph : {graph.Count}");
			Console.ReadKey();
		}
		private static void WeightedGraph()
		{ 
			var graph = new DataStructures
				.Graph
				.AdjancencySet
				.WeightedGraph<char, double>(new char[] { 'A', 'B', 'C', 'D' });

			graph.AddEdge('A', 'B', 1.2);
			graph.AddEdge('A', 'D', 1.3);
			graph.AddEdge('D', 'C', 5.5);

			Console.WriteLine("Is there an edge between A and B? {0}",graph.HasEdge('A','B')? "Yes.":"No.");
			Console.WriteLine("Is there an edge between B and A? {0}", graph.HasEdge('B', 'A') ? "Yes." : "No.");

			foreach (char vertex in graph)
			{
				Console.WriteLine(vertex);
				foreach (char key in graph.GetVertex(vertex))
				{
					var node = graph.GetVertex(key);
					Console.WriteLine($"   {vertex} - "+
					 $"{node.GetEdge(graph.GetVertex(vertex)).Weight<double>()} - "+ 
					 $"{key}");
				}
			}

			Console.WriteLine($"Number of vertex in graph : {graph.Count}");

			Console.ReadKey();

		}
		private static void Graph()
		{
			var graph = new DataStructures
				.Graph
				.AdjancencySet
				.Graph<char>(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' });

			graph.AddEdge('A', 'B');
			graph.AddEdge('A', 'D');
			graph.AddEdge('C', 'D');
			graph.AddEdge('C', 'E');
			graph.AddEdge('D', 'E');
			graph.AddEdge('E', 'F');
			graph.AddEdge('F', 'G');

			Console.WriteLine("Is there an edge between A and B ? {0}", graph.HasEdge('A', 'B') ? "Yes." : "No!");
			Console.WriteLine("Is there an edge between B and A ? {0}", graph.HasEdge('B', 'A') ? "Yes." : "No!");
			Console.WriteLine("Is there an edge between B and D ? {0}", graph.HasEdge('B', 'D') ? "Yes." : "No!");
			Console.WriteLine("Is there an edge between D and B ? {0}", graph.HasEdge('D', 'B') ? "Yes." : "No!");

			foreach (var key in graph)
			{
				Console.WriteLine(key);
				foreach (var vertex in graph.GetVertex(key).Edges)
				{
					Console.WriteLine("   {0}", vertex);
				}

			}
			Console.WriteLine($"Number of vertex in the graph : {graph.Count}");

			Console.ReadKey();
		}

		private static void Set()
		{
			var disjointSet = new DataStructures
				.Set
				.DisjointSet<int>(new int[] { 0, 1, 2, 3, 4, 5, 6 });
			disjointSet.Union(5, 6);
			disjointSet.Union(1, 2);
			disjointSet.Union(0, 2);
			for (int i = 0; i < 7; i++)
			{
				Console.WriteLine($"Find({i}) = {disjointSet.FindSet(i)} ");
			}

			Console.ReadKey();
		}
		private static void Shared() { 
			var heap = new DataStructures
				.Heap
				.BinaryHeap<int>( DataStructures.Shared.SortDirection.Asceding,new int[] { 54,45,36,27,29,18,21,99 });//Hata var olduğu gibi listeliyor. 5,6,7,8,9. videolara tekrar bak!!
			//Console.WriteLine(heap.DeleteMinMax() + " has ben removed.");
			foreach (var item in heap)
			{
				Console.Write(item+" ");
			}
			Console.ReadKey();
		}
		private static void Tree2()
		{ 
			var bst=new BST<int>(new int[] { 23, 16, 45, 3, 22, 37, 99});
			foreach (var item in bst)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine();
			new BinaryTree<int>().PrintPaths(bst.Root);// Yapraklara giden yolu ekrana yazdırır

			bst.Remove(bst.Root, 22);//22 değerli yaprağı sildi yaprak sayısı 4 den 3 e indi

			Console.WriteLine($"Number of leafs :"+$" {BinaryTree<int>.NumberOfLeafs(bst.Root)}");
			Console.WriteLine($"Number of full nodes :" + $" {BinaryTree<int>.NumberOfFullNodes(bst.Root)}");
			Console.WriteLine($"Number of half nodes :" + $" {BinaryTree<int>.NumberOfFalfNodes(bst.Root)}");

			var bt = new BinaryTree<char>();
			bt.Root = new Node<char>('F');
			bt.Root.Left = new Node<char>('A');
			bt.Root.Right = new Node<char>('T');
			bt.Root.Left.Left = new Node<char>('D');

			var list = bt.LevelOrderNonRecursiveTraversal(bt.Root);
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine($"Deepest Node: {bt.DeepestNode(bt.Root)}");
			Console.WriteLine($"Deepest Node: {bt.DeepestNode()}");
			Console.WriteLine($"Max. Depth  : {BinaryTree<char>.MaxDepth(bt.Root)}");


			Console.ReadKey();
		}
		private static void Tree() 
		{ 
			var BST = new BST<int>(new List<int>() { 23,16,45,3,22,37,99});

			var bt = new BinaryTree<int>();
		    
			bt.PreOrder(BST.Root)
			.ForEach(node=>Console.Write($"{node,-3} "));			
			
			Console.WriteLine();
			
			bt.PreOrderNonRecursiveTraversal(BST.Root)
				.ForEach(node=> Console.Write($"{node,-3} "));
			
			Console.WriteLine("\n Level Order ");
			
			bt.LevelOrderNonRecursiveTraversal(BST.Root)
				.ForEach(node=>Console.Write($"{node,-3} "));

			Console.WriteLine($"\nMinimum value : {BST.FindMin(BST.Root)}");
			Console.WriteLine($"Minimum value : {BST.FindMax(BST.Root)}");
			
			var keynode = BST.Find(BST.Root, 20);
			
			if(keynode!=null)
			   Console.WriteLine($"{keynode.Value} is find.");
			
			BST.Remove(BST.Root,3);
			
			Console.WriteLine();
			
			bt.LevelOrderNonRecursiveTraversal(BST.Root)
			.ForEach(node => Console.Write($"{node,-3} "));
			
			BST.Remove(BST.Root, 23);
			
			Console.WriteLine();
			
			bt.LevelOrderNonRecursiveTraversal(BST.Root)
			.ForEach(node => Console.Write($"{node,-3} "));

			Console.WriteLine($"\nMinimum value : {BST.FindMin(BST.Root)}");
			Console.WriteLine($"Minimum value : {BST.FindMax(BST.Root)}");
			Console.WriteLine($"Depth :{DataStructures._Tree.BinaryTree.BinaryTree<int>.MaxDepth(BST.Root)}");
			Console.ReadKey();
		}
		private static void Queue()
		{
			//Console.WriteLine(PostFixExample.Run("231*+9-"));
			var numbers = new int[] { 10, 20, 30 };
			var q1 = new Queue<int>();
			var q2 = new Queue<int>(QueueType.LinkedList);
			foreach (var number in numbers)
			{
				Console.WriteLine(number);
				q1.EnQueue(number);
				q2.EnQueue(number);
			}
			Console.WriteLine($"q1 Count : {q1.Count}");
			Console.WriteLine($"q2 Count : {q2.Count}");

			Console.WriteLine($"{q1.DeQueue()} has been removed from q1");
			Console.WriteLine($"{q2.DeQueue()} has been removed from q2");

			Console.WriteLine($"q1 Peek : {q1.Peek()}");
			Console.WriteLine($"q2 Peek : {q2.Peek()}");
			Console.ReadKey();
		}
		private static void Stack()
		{
			var charset = new char[] { 'a', 'b', 'c', 'd', 'e' };
			var stack1 = new Stack<char>();
			var stack2 = new Stack<char>(StackType.LinkedList);
			foreach (var c in charset)
			{
				Console.WriteLine(c);
				stack1.Push(c);
				stack2.Push(c);
			}
			Console.WriteLine("\nPeek");
			Console.WriteLine($"Stack1: {stack1.Peek()}");
			Console.WriteLine($"Stack2: {stack2.Peek()}");

			Console.WriteLine("\nCount");
			Console.WriteLine($"Stack1: {stack1.Count}");
			Console.WriteLine($"Stack2: {stack2.Count}");

			Console.WriteLine("\nPop");
			Console.WriteLine($"Stack1: {stack1.Pop()} has been removed");
			Console.WriteLine($"Stack2: {stack2.Pop()} has been removed");
			Console.ReadKey();
		}
		private static void DoubleLinkedListApp03()
		{
			var list = new DoubleLinkedList<int>(new int[] { 23, 44, 55, 61 });
			list.Remove(55);
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
			Console.ReadKey();
		}
		private static void DoubleLinkedListApp02() 
		{
			var list = new DoubleLinkedList<char>(new List<char>() { 'a', 'b', 'c' });
			//var list = new DoubleLinkedList<char>(new char[]= { 'a', 'b', 'c' });

			list.RemoveFirst();
			//Console.WriteLine($"{list.RemoveFirst()} has been removed from list.");
			Console.WriteLine($"{list.RemoveLast()} has been removed from list.");

			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
			Console.ReadKey();
		}
		private static void DoubleLinkedListApp01() 
		{ 
			var list = new DoubleLinkedList<int>();
			list.AddFist(12);
			list.AddFist(23);
			//23 12

			list.AddLast(44);
			list.AddLast(55);
			//23 12 44 55

			list.AddAfter(list.Head.Next, new DoubleLinkedListNode<int>(13));
			// 23 12 13 44 55
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
			Console.ReadKey();
		}
		private static void SingleLinkedListApp05()
		{
			var list = new SingleLinkedList<int>(new int[] { 1, 2, 3,4,5,6,7 });
			list.Remove(2);
			list.Remove(6);
			list.Remove(13);//hata verir
			list.Remove(1);
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
			Console.ReadKey();
		}
		private static void SingleLinkedListApp04() { 
			Console.ReadKey();
			var rnd = new Random();
			var initial = Enumerable.Range(1, 5).OrderBy(x => rnd.Next()).ToList();
			var list = new SingleLinkedList<int>(initial);
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
			list.RemoveFirst();
			Console.WriteLine($"{list.RemoveFirst()} has been removed.");
			Console.WriteLine($"{list.RemoveLast()} has been removed.");
			
			foreach (var item in list)
			{
				Console.WriteLine(item+" ");
			}
		}
		private static void SingleLinkedListApp03() 
		{ 
			var rnd = new Random();
			var initial = Enumerable.Range(1,10).OrderBy(x=>rnd.Next()).ToList();
			var linkedlist = new SingleLinkedList<int>(initial);
			var q = from item in linkedlist
					where item % 2 == 1
					select item;
			foreach (var item in q)
			{
				Console.WriteLine(item);
			}
			linkedlist.Where(x => x > 5)
				.ToList()
				.ForEach(x => Console.WriteLine(x + " "));
			Console.ReadKey();
		}
		private static void SingleLinkedListApp02()
		{
				var arr = new char[] { 'a', 'b', 'c' };
			var arrList = new ArrayList(arr);
			var list = new List<char>(arr);
			var clinkedlist = new LinkedList<char>(arr);
			var linkedlist = new SingleLinkedList<char>(arr);
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}

			Console.ReadKey();
		}
		private static void SingleLinkedListApp01() { 
			//var p1 = new DataStructures.Array.Array<int>(1,2,3,4);
			//var p2 = new int[] {8,9,10,11 };
			//var p3 = new List<int> {5,15,20,25};
			//var p4 = new ArrayList() {12,13,14 };// int tip tanımlanmadığı için tip güzenliğinden dolayı hata verir

			/*var arr = new DataStructures
				.Array
				.Array<int>(1,3,5,7);
			var crr = arr.Clone() as DataStructures.Array.Array<int>;//ikisi farklı nesne oluyor 
			foreach (var item in arr)
			{
				Console.WriteLine($"{item,-3}");
			}
			Console.WriteLine($"{arr.Count}/{arr.Capacity}");
			foreach (var item in crr)
			{
				Console.WriteLine($"{item,-3}");
			}
		for (int i = 0; i < 8; i++)
		{
			arr.Add(i + 1);

			Console.WriteLine($"{i+1} has been added to array.");
			Console.WriteLine($"{arr.Count}/{arr.Capacity}");
		}
		for (int i = arr.Count; i >=1; i--)
		{
			Console.WriteLine($"{arr.Remove()} has been removed from the array.");
			Console.WriteLine($"{arr.Count}/{arr.Capacity}");
		}
		arr.Where(x => x % 2 == 0)
			.ToList()
			.ForEach(x => Console.WriteLine(x));
		Console.WriteLine($"{arr.Count}/{arr.Capacity}");

		var linkedlist = new SingleLinkedList<int>();
		linkedlist.AddFirst(1);
		linkedlist.AddFirst(2);
		linkedlist.AddFirst(3);
		//3 2 1  O(1)
		linkedlist.AddLast(4);
		linkedlist.AddLast(5);
		//3 2 1 4 5  O(n)
		linkedlist.AddAfter(linkedlist.Head.Next,32);
		linkedlist.AddAfter(linkedlist.Head.Next.Next, 33);
		//3 2 32 33 1 4 5 
		foreach (var item in linkedlist)
		{
			Console.WriteLine(item);
		}
		Console.ReadKey();
	}*/
	}
}
