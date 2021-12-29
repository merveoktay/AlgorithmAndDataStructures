using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SortingAlgorithms
{
	public static class MergeSort
	{
		public static void Sort<T>(T[] array) where T : IComparable
		{
			Sort(array, 0, array.Length - 1) ;
		}
		private static void Sort<T>(T[] array,int left,int right) where T:IComparable
		{
			if (left < right) {
				int middle = (left + right) / 2;
				Sort(array,left,middle);
				Sort(array,middle+1,right);
				Merge(array,left,middle,right);
			}
		
		}
		private static void Merge<T>(T[] array, int left,int middle, int right) where T : IComparable
		{
			T[] leftArray = new T[middle - left + 1];
			T[] RightArray = new T[right -middle ];
			System.Array.Copy(array,left,leftArray,0,middle-left+1);
			System.Array.Copy(array, middle+1, RightArray, 0, right - middle);
			int i = 0;
			int j = 0;
			for (int k = left; k < right+1; k++)
			{
				if(i==leftArray.Length)
				{
					array[k] = RightArray[j];
					j++;
				}
				else if(j==RightArray.Length)
				{
					array[k] = leftArray[i];
					i++;
				}
				else if (leftArray[i].CompareTo(RightArray[j]) < 0)
				{
					array[k] = leftArray[i];
					i++;
				}
				else
				{
					array[k] = RightArray[j];
					j++;
				}
			}
		}
	}
}
