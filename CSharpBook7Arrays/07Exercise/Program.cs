using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var k = int.Parse(Console.ReadLine());
			var n = int.Parse(Console.ReadLine());
			var s = Console.ReadLine();
			int[] array = new int[n];
			array = s.Split(' ').Select(str => int.Parse(str)).ToArray();

			var maxSum = int.MinValue;
			int maxSumStart = 0;

			for (int i = 0; i < n; i++)
			{
				int currSum = 0;
				for (int j = i; j <= k-1; j++)
				{
					currSum += array[j];
				}
				if (currSum > maxSum)
				{
					maxSum = currSum;
					maxSumStart = i;
				}
			}
			Console.WriteLine("Max sum: {0}", maxSum);
			for (int i = maxSumStart; i <= maxSumStart + k; i++)
			{
				Console.Write("{0} ", array[i]);
			}

		}
	}
}
