using DataStructures.LinkedList.DoubleLinkedList;
using System;

namespace DataStructures.Queue
{
	internal class LinkedListQueue<T> : IQueue<T>
	{
		private readonly DoubleLinkedList<T> list = new DoubleLinkedList<T>();
		public int Count { get; private set; }

		public T DeQueue()
		{
			if (Count == 0)
				throw new Exception("Emty queue!");
			var temp = list.RemoveFirst();
			Count--;
			return temp;
		}

		public void EnQueue(T value)
		{
			if (value == null)
				throw new ArgumentNullException();
			list.AddLast(value);
			Count++;
		}

		public T Peek()=>Count==0 ? throw new Exception("Emty queue!")
			: list.Head.Value;
		/*{
			if (Count == 0)
				throw new Exception("Emty queue!");
			return list.Head.Value;
		}*/
	}
}