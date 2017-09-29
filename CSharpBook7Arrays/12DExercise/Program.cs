using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12DExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			int[,] matrix = new int[n, n];

			int currentElement = 1;
			int round = 0;
			int row = 0;
			int column = 0;

			for (int i = 0; i < n; i++)                 //start of outer round; round = 0
			{
				matrix[row, column] = currentElement;
				currentElement++;
				if (row == n - 1)
				{
					break;
				}
				row++;
			}
			column++;
			for (int j = 0; j < n - 1; j++)
			{
				matrix[row, column] = currentElement;
				currentElement++;
				if (column == n - 1)
				{
					break;
				}
				column++;

			}
			row--;
			for (int k = 0; k < n - 1; k++)
			{
				matrix[row, column] = currentElement;
				currentElement++;
				if (row == 0)
				{
					break;
				}
				row--;
			}
			column--;
			for (int l = 0; l < n - 2; l++)
			{
				matrix[row, column] = currentElement;
				currentElement++;
				if (column == 1)
				{
					break;
				}
				column--;
			}
			round++;                                              //end of outer round; round = 1

			if (n%2 == 0)										//for even N, start inner rounds from 1 to (n/2 - 1)
			{
				for (round = 1; round < n / 2; round++)
				{
					row++;    
					var stretch = n - round*2;                  //stretch is the side length of the new round
					for (int i = 0; i < stretch; i++)
					{
						matrix[row, column] = currentElement;
						currentElement++;
						if (row == n - 1 - round)
						{
							break;
						}
						row++;
					}
					column++;
					for (int j = 0; j < stretch - 1; j++)
					{
						matrix[row, column] = currentElement;
						currentElement++;
						if (column == n - 1 - round)
						{
							break;
						}
						column++;
					}
					row--;
					for (int k = 0; k < stretch - 1; k++)
					{
						matrix[row, column] = currentElement;
						currentElement++;
						if (row == round)
						{
							break;
						}
						row--;
					}
					column--;
					for (int l = 0; l < stretch - 2; l++)
					{
						matrix[row, column] = currentElement;
						currentElement++;
						if (column == round+1)
						{
							break;
						}
						column--;
					}
				}
			}

			else 
			{
				for (round = 1; round <= n / 2; round++)              //for even N, start inner rounds from 1 to (n/2)
				{
					row++;    
					var stretch = n - round * 2;
					for (int i = 0; i < stretch; i++)
					{
						matrix[row, column] = currentElement;
						currentElement++;
						if (row == n - 1 - round)
						{
							break;
						}
						row++;
					}
					column++;
					for (int j = 0; j < stretch - 1; j++)
					{
						matrix[row, column] = currentElement;
						currentElement++;
						if (column == n - 1 - round)
						{
							break;
						}
						column++;
					}
					row--;
					for (int k = 0; k < stretch - 1; k++)
					{
						matrix[row, column] = currentElement;
						currentElement++;
						if (row == round)
						{
							break;
						}
						row--;
					}
					column--;
					for (int l = 0; l < stretch - 2; l++)
					{
						matrix[row, column] = currentElement;
						currentElement++;
						if (column == round + 1)
						{
							break;
						}
						column--;
					}
				}
			}
			
			for (row = 0; row < n; row++)
			{
				for (column = 0; column < n; column++)
				{
					Console.Write("{0,4} ", matrix[row, column]);
				}
				Console.WriteLine();
			}
		}
	}
}
