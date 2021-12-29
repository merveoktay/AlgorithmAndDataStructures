using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList.DoubleLinkedList
{
	 public class DoubleLinkedListNode<T>
	{
		public DoubleLinkedListNode<T> Prev { get; set; }
		public DoubleLinkedListNode<T> Next { get; set; }
		public T Value { get; set; }
		public DoubleLinkedListNode(T value)
		{
			Value = value;
		}
		public override string ToString()=> Value.ToString();
		
	}
}
