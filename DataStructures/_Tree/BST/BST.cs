﻿using DataStructures._Tree.BinaryTree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures._Tree.BST
{
	public class BST<T> : IEnumerable<T>
		where T:IComparable//karşılaştırma yapar küçükse -1 eşitse 0 büyükse 1 geri döndürür
	{
		public Node<T> Root { get; set; }
		public BST()
		{

		}
		public BST(IEnumerable<T> collection)
		{
			foreach (var item in collection)
				Add(item);
		}
		public IEnumerator<T> GetEnumerator()
		{
			return new BSTEnumerator<T>(Root);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
		public void Add(T value)
		{
			if (value == null)
				throw new ArgumentNullException();
			var newNode = new Node<T>(value);

			if(Root==null)
			{
				Root = newNode;
			}
			else
			{
				var current = Root;
				Node<T> parent;
				while(true)
				{
					parent = current;
					//sol alt
					if(value.CompareTo(current.Value)<0)
					{
						current = current.Left;
						if(current==null)
						{
							parent.Left = newNode;
							break;
						}
					}
					//sağ alt
					else
					{
						current = current.Right;
						if(current==null)
						{
							parent.Right = newNode;
							break;
						}
					}
				}
			}
		}
		public Node<T> FindMin(Node<T> root)
		{
			var current = root;
			while (!(current.Left == null))
				current = current.Left;
			return current;
		}
		public Node<T> FindMax(Node<T> root)
		{
			var current = root;
			while (!(current.Right == null))
				current = current.Right;
			return current;
		}
		public Node<T> Find(Node<T> root,T key)
		{
			var current = root;
			while (key.CompareTo(current.Value)!=0)
			{
				if (key.CompareTo(current.Value) < 0)
					current = current.Left;
				else
					current = current.Right;
				if (current == null)
					return default(Node<T>); //throw new Exception("Could not found!");
			}
			return current;
		}
		public Node<T> Remove(Node<T> root, T key)
		{
			if (root == null)
				return root;
			if (key.CompareTo(root.Value) < 0)
				root.Left = Remove(root.Left, key);
			else if (key.CompareTo(root.Value) > 0)
				root.Right = Remove(root.Right,key);
			else
			{
				if (root.Left == null)
					return root.Right;
				else if (root.Right == null)
					return root.Left;
				root.Value = FindMin(root.Right).Value;
				root.Right = Remove(root.Right,root.Value);
			}
			return root;
		}

	}
}
