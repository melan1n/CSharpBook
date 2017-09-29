using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			int[,] array = new int[n, n];
			var rows = n;
			var columns = n;
			var nextRow = 0;
			var nextColumn = 0;
			//Find center of matrix
			//if odd -> central index = rows/2 + 1, col/2 + 1
			if (n%2 == 1)
			{
				array[rows / 2, columns / 2] = 0;
				nextRow = rows / 2 + 1;
				nextColumn = columns / 2;
			}
			//else -> central index = rows/2, col/2 + 1
			else
			{
				array[rows / 2 - 1, columns / 2] = 0;
				nextRow = rows / 2;
				nextColumn = columns / 2;
			}
			//first round values count  =  8 = 4*1 + 4 = 1*8 - seed 1
			//second round values count = 16 = 4*3 + 4 = 2*8 - seed 9
			//third round ....          = 24 = 4*5 + 4 = 3*8 - seed 25
			//4 round					= 32 = 4*7 + 4 = 4*8 - seed 49
			//5 round					= 40 = 4*9 + 4 = 5*8 - seed 89
			//6 round					= 48 = 4*11 + 4 = 6*8 - seed 137

			//for each round (set counter for rounds 8 is 1, 16 is 2 etc.)
			int round = 1;
			//count of numbers between two changes of direction
			int jCount = 1;

			for (int i = 1; i <= n*n-1; i = i + (round-1)*8)
			{
				//change direction -> set values -> change direction -> set values....				
				int dir = 1;
				for (int j = i; j <= i+8*round-1; j++) 
				{
					
					if (j==n*n)
					{
						break;
					}
					array[nextRow, nextColumn] = j;
					//direction changes on every number = current rouond * 2
					if (jCount/round==2) 
					{
						dir++;
						jCount = 0;
					}
					if (dir==1)
					{
						nextColumn--;
					}
					else if (dir==2)
					{
						nextRow--;
					}
					else if (dir == 3)
					{
						nextColumn++;
					}
					else
					{
						nextRow++;
					}
					jCount++;
				}
				
				round++;
				dir = 1;
				jCount = 1;
			}
			for (int t = 0; t < n; t++)
			{
				for (int s = 0; s < n; s++)
				{
					Console.Write($"{array[t,s],3}   ");
				}
				Console.WriteLine();

			}




		}
	}
}
