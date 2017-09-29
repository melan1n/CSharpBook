using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07ExerciseNew
{
	class Program
	{
		static void Main(string[] args)
		{
			var k = int.Parse(Console.ReadLine());
			var n = int.Parse(Console.ReadLine());
			var s = Console.ReadLine();                                    //read array space delimited string
			int[] array = new int[n];
			array = s.Split(' ').Select(str => int.Parse(str)).ToArray();  //transform string into Int array

			var maxSum = int.MinValue;
			int maxSumStart = 0;

			for (int i = 0; i <= n-k; i++)
			{
				int currSum = 0;
				for (int j = i; j <= i+k-1; j++)
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
			for (int i = maxSumStart; i <= maxSumStart + k -1; i++)
			{
				Console.Write("{0} ", array[i]);
			}

		}
	}
}
