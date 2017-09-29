using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var m = int.Parse(Console.ReadLine());
			int[][] myArray = new int[m][];

			for (int i = 0; i < m; i++)
			{
				var s = Console.ReadLine();
				myArray[i] = s.Split(' ').Select(str => int.Parse(str)).ToArray(); 
			}

			int rowStart = 0;
			int columnStart = 0;
			int maxSum = int.MinValue;

			for (int i = 0; i < m-2; i++)
			{
				for (int j = 0; j < n-2; j++)
				{
					var sum = myArray[i][j] + myArray[i][j + 1] + myArray[i][j + 2] +
						myArray[i + 1][j] + myArray[i + 1][j + 1] + myArray[i + 1][j + 2] +
						myArray[i + 2][j] + myArray[i + 2][j + 1] + myArray[i + 2][j + 2];
					if (sum>maxSum)
					{
						maxSum = sum;
						rowStart = i;
						columnStart = j;
					}
				}
			}

			for (int i = rowStart; i < rowStart + 3; i++)
			{
				for (int j = columnStart; j < columnStart + 3; j++)
				{
					Console.Write("{0,4} ", myArray[i][j]);
				}
				Console.WriteLine();
			}
			Console.WriteLine("Max Sum is: {0}", maxSum);
		}
	}
}
