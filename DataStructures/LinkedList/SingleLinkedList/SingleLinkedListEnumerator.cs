using System.Collections;
using System.Collections.Generic;

namespace DataStructures.LinkedList.SingleLinkedList
{
	internal class SingleLinkedListEnumerator<T> : IEnumerator<T>
	{
		private SingleLinkedListNode<T> Head;
		private SingleLinkedListNode<T> _current;
		public	SingleLinkedListEnumerator(SingleLinkedListNode<T> head)
		{
			Head = head;
			_current = null;
		}
		public T Current => _current.Value;

		object IEnumerator.Current => Current;

		public void Dispose()
		{
			Head = null;
		}

		public bool MoveNext()
		{
			if(_current==null)
			{
				_current = Head;
				return true;
			}
			else
			{
				_current = _current.Next;
				return _current!= null ? true:false;
			}
		}

		public void Reset()
		{
			_current = null;
		}
	}
}