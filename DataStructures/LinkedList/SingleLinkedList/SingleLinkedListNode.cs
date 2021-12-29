using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList.SingleLinkedList
{
	public class SingleLinkedListNode<T>
	{
		public SingleLinkedListNode<T> Next { get; set; }
		public T Value { get; set; }
		public SingleLinkedListNode(T value)
		{
			Value = value;
		}
		public override string ToString() => $"{Value}";


	}
}
