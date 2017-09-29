using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arrayA = new int[] { 3, 5, 7, 2, 9, 6, 4, 5, 1, 3 };   

			quicksort(arrayA, 0, arrayA.Length - 1);

			void quicksort(int[] A, int lo, int hi)
			{
				if (lo < hi)
				{
					int p = partition(A, lo, hi);
					quicksort(A, lo, p - 1);
					quicksort(A, p + 1, hi);
				}
			}
			int partition(int[] A, int lo, int hi)
			{
				int pivot = A[hi];         //Pick a pivot from the array. typically the last element in the array
				int i = lo - 1;            //maintains index i

				//all elements with values less than the pivot come before the pivot
				for (int j = lo; j <= hi - 1; j++)
				{
					if (A[j] < pivot)
					{
						i += 1;      
						int temp = A[i];
						A[i] = A[j];
						A[j] = temp;
					}
				}
				//all elements with values greater than the pivot come after it(equal values can go either way)
				if (A[hi] < A[i + 1])
				{
					int temp = A[i + 1];
					A[i + 1] = A[hi];
					A[hi] = temp;
				}
				return i = i+1;
			}
			// print out sorted array
			for (int i = 0; i < arrayA.Length; i++)
			{
				Console.Write("{0} ", arrayA[i]);
			}
		}
	}
}
