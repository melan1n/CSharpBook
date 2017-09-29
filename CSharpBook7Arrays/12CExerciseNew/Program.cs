using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12CExerciseNew
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			int[,] matrix = new int[n, n];

			int rows = 0;
			int columns = 0;
			int currentElement = 1;

			for (var diagonal = 1; diagonal <= 2 * n - 1; diagonal++)
			{
				if (diagonal <= n)
				{
					rows = n - diagonal;
					for (columns = 0; columns < diagonal; columns++)
					{
						matrix[rows, columns] = currentElement;
						if (rows == n - 1)
						{
							break;
						}
						else
						{
							rows++;
							currentElement++;
						}
					}
				}
				else
				{
					rows = 0;
					for (columns = diagonal - n; columns < n; columns++)
					{
						matrix[rows, columns] = currentElement;
						if (columns == n - 1)
						{
							break;
						}
						else
						{
							rows++;
							currentElement++;
						}
					}
				}

				currentElement++;
			}

			for (int k = 0; k < n; k++)
			{
				for (int l = 0; l < n; l++)
				{
					Console.Write("{0,4} ", matrix[k, l]);
				}
				Console.WriteLine();

			}
		}
	}
}
