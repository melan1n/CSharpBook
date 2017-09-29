using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			//This solution doesn't account for longest sequence in diagonals from right to left
			string[][] myArray = {
			new string[] {"ha", "fifi", "ho", "hi"},
			new string[] {"fo", "ha", "hi", "xx"},
			new string[] {"xxx", "ho", "ha", "xx"},
			};

			int getColumnLength(string[][] jaggedArray, int columnIndex)   //define method to return column length at column index X
			{
				int count = 0;
				foreach (string[] row in jaggedArray)
				{
					if (columnIndex < row.Length) count++;
				}
				return count;
			}

			//instanciate variables
			var maxCount = 1;
			string longestSequenceElement = "";
			int currentCount;
			string prevItem;

			for (int row = 0; row < getColumnLength(myArray, 0); row++)                  //scan horizontally for longest sequence
			{
				currentCount = 1;
				prevItem = myArray[row][0];

				for (var column = 1; column < myArray[0].Length; column++)
				{
					if (myArray[row][column] == prevItem)
					{
						currentCount++;
						if (currentCount >= maxCount)
						{
							maxCount = currentCount;
							longestSequenceElement = myArray[row][column];
						}
					}
					else
					{
						currentCount = 1;
					}
					prevItem = myArray[row][column];
				}
			}

			for (int column = 0; column < myArray[0].Length; column++)                       //scan vertically for longest sequence
			{
				currentCount = 1;
				prevItem = myArray[0][column];

				for (var row = 1; row < getColumnLength(myArray, 0); row++)
				{
					if (myArray[row][column] == prevItem)
					{
						currentCount++;
						if (currentCount >= maxCount)
						{
							maxCount = currentCount;
							longestSequenceElement = myArray[row][column];
						}
					}
					else
					{
						currentCount = 1;
					}
					prevItem = myArray[row][column];
				}
			}
			
			for (int row = getColumnLength(myArray, 0) - 2; row >= 0; row--)                       //scan diagonally for longest sequence, start at col [0] and decrease row index
			{
				var column = 0;
				currentCount = 1;
				prevItem = myArray[row][column];
				
				for (var j = row + 1; j < getColumnLength(myArray, 0); j++)
				{
					if (myArray[j][column + 1] == prevItem)
					{
						currentCount++;
						if (currentCount >= maxCount)
						{
							maxCount = currentCount;
							longestSequenceElement = myArray[j][column + 1];
						}
					}
					else
					{
						currentCount = 1;
					}
					prevItem = myArray[j][column + 1];
					column++;
				}
			}

			//scan diagonally for longest sequence, start at col [0] and increase col index
			for (int column = 1; column < myArray[0].Length - 2; column++)
			{
				int row = 0;
				currentCount = 1;
				prevItem = myArray[row][column];

				for (var j = row + 1; j < getColumnLength(myArray, 0); j++)
				{
					if (myArray[j][column + 1] == prevItem)
					{
						currentCount++;
						if (currentCount >= maxCount)
						{
							maxCount = currentCount;
							longestSequenceElement = myArray[j][column + 1];
						}
					}
					else
					{
						currentCount = 1;
					}
					prevItem = myArray[j][column + 1];
					column++;
				}
			}
			
			
			Console.WriteLine("Longest sequence is: {0}", maxCount);
			for (int i = 0; i < maxCount; i++)
			{
				Console.Write("{0} ", longestSequenceElement);
			}
			Console.WriteLine();
		}
	}
}
