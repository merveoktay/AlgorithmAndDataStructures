using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList.DoubleLinkedList
{
	public class DoubleLinkedList<T> : IEnumerable
	{
		public DoubleLinkedListNode<T> Head { get; set; }
		public DoubleLinkedListNode<T> Tail { get; set; }

		private bool isHeadNull => Head == null;
		private bool isTailNull => Tail == null;
		public DoubleLinkedList()
		{

		}
		public DoubleLinkedList(IEnumerable<T> collection)
		{
			foreach (var item in collection)
			{
				AddLast(item);
			}
		}
		public void AddFist(T value)
		{
			var newNode = new DoubleLinkedListNode<T>(value);
			if (Head != null)
			{
				Head.Prev = newNode;
			}
			newNode.Next = Head;
			newNode.Prev = null;
			Head = newNode;
			if (Tail == null)
			{
				Tail = Head;
			}

		}
		public void AddLast(T value)
		{
			if (Tail == null)
			{
				AddFist(value);
				return;
			}
			var newNode = new DoubleLinkedListNode<T>(value);
			Tail.Next = newNode;
			newNode.Next = null;
			newNode.Prev = Tail;
			Tail = newNode;
			return;
		}
		public void AddAfter(DoubleLinkedListNode<T> refNode, DoubleLinkedListNode<T> newNode)
		{
			if (refNode == null)
				throw new ArgumentNullException();

			if (refNode == Head && refNode == Tail)
			{
				refNode.Next = newNode;
				refNode.Prev = null;
				newNode.Prev = refNode;
				newNode.Next = null;
				Head = refNode;
				Tail = newNode;
				return;
			}
			if (refNode != Tail)
			{
				newNode.Prev = refNode;
				newNode.Next = refNode.Next;
				refNode.Next.Prev = newNode;
				refNode.Next = newNode;
			}
			else
			{
				newNode.Prev = refNode;
				newNode.Next = null;
				refNode.Next = newNode;
				Tail = newNode;
			}
		}
		public void AddBefore(DoubleLinkedListNode<T> refNode, DoubleLinkedListNode<T> newNode)
		{
			throw new NotImplementedException();
		}
		private List<DoubleLinkedListNode<T>> GetAllNodes()
		{
			var list = new List<DoubleLinkedListNode<T>>();
			var current = Head;
			while (current != null)
			{
				list.Add(current);
				current = current.Next;
			}
			return list;
		}

		public IEnumerator GetEnumerator()
		{
			return GetAllNodes().GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
		public T RemoveFirst()
		{
			if (isHeadNull)
			{
				throw new Exception("");
			}
			var temp = Head.Value;
			if (Head == Tail)
			{
				Head = null;
				Tail = null;
			}
			else
			{
				Head = Head.Next;
				Head.Prev = null;
			}
			return temp;
		}
		public T RemoveLast()
		{
			if (isTailNull)
				throw new Exception("Empty list.");
			var temp = Tail.Value;
			if (Tail == Head)
			{
				Head = null;
				Tail = null;
			}
			else
			{
				Tail.Prev.Next = null;
				Tail = Tail.Prev;
			}
			return temp;
		}
		public void Remove(T value)
		{
			if (isHeadNull)
				throw new Exception("Empty list.");
			if (Head == Tail)
			{
				if (Head.Value.Equals(value))
				{
					RemoveFirst();
				}
				return;
			}

			var current = Head;
			while (current != null)
			{
				if (current.Value.Equals(value))
				{
					if (current.Prev == null)
					{
						current.Next.Prev = null;
						Head = current.Next;
					}
					else if (current.Next == null)
					{
						current.Prev.Next = null;
						Tail = current.Prev;
					}
					else
					{
						current.Prev.Next = current.Next;
						current.Next.Prev = current.Prev;
					}
					break;
				}
				current = current.Next;
			}
		}
	}
}
