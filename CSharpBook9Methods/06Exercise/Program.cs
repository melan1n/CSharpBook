using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05Exercise;

namespace _06Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int firstIndexOfGreaterElement = GetFirstIndexOfGreaterElementThanNeighbours(arr);
			Console.WriteLine($"First index of element greater than neighbours is {firstIndexOfGreaterElement}");
		}

		private static int GetFirstIndexOfGreaterElementThanNeighbours(int[] arr)
		{
			int arrayIndex = -1;
			for (int i = 0; i < arr.Length - 1; i++)
			{				
				if (_05Exercise.Program.IsBiggerThanNeighbours(arr, i) == true)
				{
					arrayIndex = i;
				}
			}
			return arrayIndex;
		}
	}
}
