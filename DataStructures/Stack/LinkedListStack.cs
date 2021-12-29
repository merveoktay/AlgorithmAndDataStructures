using DataStructures.LinkedList.SingleLinkedList;
using System;

namespace DataStructures.Stack
{
	public class LinkedListStack<T> : IStack<T>
	{
		private readonly SingleLinkedList<T> list = new SingleLinkedList<T>();
		public int Count { get; private set; }

		public T Peek()
		{
			if (Count == 0)
				throw new Exception("Empty Stack!");
			return list.Head.Value;
		}

		public T Pop()
		{
			if (Count == 0)
				throw new Exception("Empty Stack!");
			var temp = list.RemoveFirst();
			Count--;
			return temp;

		}

		public void Push(T value)
		{
			if (value == null)
				throw new ArgumentNullException();
			list.AddFirst(value);
			Count++;
		}
	}
}