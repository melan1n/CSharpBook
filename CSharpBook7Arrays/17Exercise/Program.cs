using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arrayA = new int[] { 2, 3, 7, 8, 1, 4, 9, 0, 6, 5 };
			int[] arrayB = new int[arrayA.Length];
			int n = arrayA.Length;

			TopDownMergeSort(arrayA, arrayB, n);

			// Array A[] has the items to sort; array B[] is a work array.
			void TopDownMergeSort(int[] A, int[] B, int length)
			{
				CopyArray(A, 0, length, B);           // duplicate array A[] into B[]
				TopDownSplitMerge(B, 0, length, A);   // sort data from B[] into A[]
			}
			
			void CopyArray(int[] A, int iBegin, int iEnd, int[] B)
			{
				for (var k = iBegin; k < iEnd; k++)
				{
					B[k] = A[k];   // duplicate array A[] into B[]
				}
			}

			//TopDownSplitMerge(arrayB, 0, n, arrayA);   // sort data from B[] into A[]

			// Sort the given run of array A[] using array B[] as a source.
			// iBegin is inclusive; iEnd is exclusive (A[iEnd] is not in the set).

			void TopDownSplitMerge(int[] B, int iBegin, int iEnd, int[] A)
			{
				if (iEnd - iBegin < 2)                       // if run size == 1
					return;                                 //   consider it sorted
															  // split the run longer than 1 item into halves
				var iMiddle = (iEnd + iBegin) / 2;              // iMiddle = mid point
																// recursively sort both runs from array A[] into B[]
				TopDownSplitMerge(A, iBegin, iMiddle, B);  // sort the left  run
				TopDownSplitMerge(A, iMiddle, iEnd, B);  // sort the right run
														 // merge the resulting runs from array B[] into A[]
				TopDownMerge(B, iBegin, iMiddle, iEnd, A);
			}

			//  Left source half is A[ iBegin:iMiddle-1].
			// Right source half is A[iMiddle:iEnd-1   ].
			// Result is            B[ iBegin:iEnd-1   ].

			void TopDownMerge(int[] A, int iBegin, int iMiddle, int iEnd, int[] B)
			{
				int i = iBegin; int j = iMiddle;

				// While there are elements in the left or right runs...
				for (int k = iBegin; k < iEnd; k++)
				{
					// If left run head exists and is <= existing right run head.
					if (i < iMiddle && (j >= iEnd || A[i] <= A[j]))
					{
						B[k] = A[i];
						i = i + 1;
					}
					else
					{
						B[k] = A[j];
						j = j + 1;
					}
				}
			}
			// print out sorted array
			for (int i = 0; i < n; i++)
			{
				Console.Write("{0} ", arrayA[i]);
			}
		
		}
	}
}
