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
			var s = Console.ReadLine();
			int[] array = s.Split(' ').Select(str => int.Parse(str)).ToArray();
			
			var maxSum = int.MinValue;
			var currentSum = 0;

			for (int i = 0; i < array.Length; i++)
			{
				currentSum += array[i];
				if (currentSum < 0)
				{
					maxSum = currentSum - array[i];
					currentSum = 0;
				}
				else
				{
					maxSum = currentSum;
				}

			}
			Console.WriteLine("{0} ", maxSum);
		}
	}
}
