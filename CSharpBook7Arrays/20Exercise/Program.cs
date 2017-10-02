using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());   //array length
			int s = int.Parse(Console.ReadLine());   //target sum
			int[] array = Console.ReadLine().Split(' ').Select(str=>int.Parse(str)).ToArray();
			int[] possibleSums = new int[n];         //array of possible sums
			
			for (int i = 0; i < n; i++)              //initialize array of possible sums same as array 
			{
				possibleSums[i] = array[i];
			}

			bool[] possible = new bool[n];           //bool array to keep track if the target sum is hit
			int lastArrayIndex = -1;
			int lastPossibleIndex = -1;

			for (int i = 0; i < n; i++)              //nested loop to add any element of array to all other elements of possibleSums
			{
				for (int j = 0; j < n; j++)
				{
					if (j != i)
					{
						possibleSums[j] = possibleSums[j] + array[i];
						if (possibleSums[j] == s)   //If target sum is hit, break loop and print 'Yes'
						{
							possible[j] = true;
							lastPossibleIndex = j;
							lastArrayIndex = i;
							Console.Write("Yes -> (");
							break;
						}
					}
				}
				if (lastPossibleIndex >= 0)
				{
					break;
				}
			}
			if (lastPossibleIndex >=0)
			{
				for (int i = 0; i <= lastArrayIndex; i++)
				{
					if (i != lastPossibleIndex)
					{
						Console.Write($"{array[i]} + ");
					}
				}
				Console.Write($"{array[lastPossibleIndex]})");
			}
			
			}
		}
	}

