using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12AExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			int[,] matrix = new int[n, n];

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					matrix[i, j] = i + 1 + n * j;
					Console.Write("{0,4} ", matrix[i, j]);
				}
				Console.WriteLine();
			}


		}
	}
}
