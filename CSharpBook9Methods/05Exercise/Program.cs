using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Exercise
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[] { 1, 2, 3, 4 };
			bool result = IsBiggerThanNeighbours (arr, 0);
			Console.WriteLine($"Zero index element of array {String.Join(" ", arr)} is bigger than neighbour? {result}");
		}

		public static bool IsBiggerThanNeighbours(int[] arr, int arrayIndex)
		{
			if (arrayIndex != 0 && 
				arrayIndex != arr.Length-1 &&
				arr[arrayIndex] > arr[arrayIndex + 1] && 
				arr[arrayIndex] > arr[arrayIndex - 1])
			{
				return true;
			}
			else if (arrayIndex == 0 &&
				arr[arrayIndex] > arr[arrayIndex + 1])
			{
				return true;
			}
			else if (arrayIndex == arr.Length-1 &&
				arr[arrayIndex] > arr[arrayIndex - 1])
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
