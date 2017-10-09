using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			for (int i = 0; i < arr.Length - 1; i++)
			{
				int maxElementInUnsorted = FindMaxArrayElementInRange(arr, i, arr.Length - 1);
				int maxElementIndexInUnsorted = Array.IndexOf(arr, maxElementInUnsorted);
			
				int temp = arr[i];
				arr[i] = maxElementInUnsorted;
				arr[maxElementIndexInUnsorted] = temp;
			}
			
			Console.WriteLine(String.Join(" ", arr));
		}

		static int FindMaxArrayElementInRange(int[] arr, int startIndex, int endIndex)
		{
			int biggestElement = arr[startIndex];
			for (int i = startIndex + 1; i <= endIndex; i++)
			{
				if (arr[i] > biggestElement)
				{
					biggestElement = arr[i];
				}
			} 
			return biggestElement;
		}
	}
}