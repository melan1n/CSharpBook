using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
			int[] l = new int[array.Length];  // array for max length[i]
			int[] p = new int[array.Length];  // array for predeccesor[i]
			int max = int.MinValue;

			int LongestIncreasingSeq(int[] s) // method for calculating length of LIS
			{
				l[0] = 1;

				for (int i = 0; i < s.Length; i++) 
					p[i] = -1;

				for (int i = 1; i < s.Length; i++)
				{
					l[i] = 1;
					for (int j = 0; j < i; j++)
					{
						if (s[j] < s[i] && l[j] + 1 > l[i])
						{
							l[i] = l[j] + 1;
							p[i] = j;
							if (l[i] > max)
								max = l[i];
						}
					}
				}
				return max;
			}
			var lisLength = LongestIncreasingSeq(array);
			Console.WriteLine(lisLength);
			
			int[] lis = new int[lisLength];    //instantiate the LIS 
			int lastIndex = 0;
			for (lastIndex = array.Length-1; lastIndex >= 0 ; lastIndex--)   // find last index of array representing LIS's last element
			{
				if (l[lastIndex] == lisLength)
				{
					lis[lisLength-1] = array[lastIndex];
					break;
				}
				
			}
			lisLength = lisLength - 2;      // get to previous to last index (current index) of LIS
			for (int m = lastIndex-1; m >= 0; m--)  // loop through all elements of array backwards
			{
				if ((array[m] < array[lastIndex]) && (l[lastIndex] == 1 + l[m]) && lisLength >= 0) // if curr element < next element && l[curr] + 1 == l[next]
				{
					lis[lisLength] = array[m];     // set element of current index of LIS
					lisLength--;                           
				}
				lastIndex--;
			}
			for (int n = 0; n < lis.Length; n++)  // construct and print LIS
			{
				Console.Write("{0} ", lis[n]);
			}
			
		}
	}
}
