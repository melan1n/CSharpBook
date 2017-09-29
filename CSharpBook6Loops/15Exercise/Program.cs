using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var hexadecimal = Console.ReadLine();
			char[] array = hexadecimal.ToCharArray();
			Array.Reverse(array);
			hexadecimal = new string (array);

			int result = 0;
			char currentDigit;
			
			for (int i = 0; i < hexadecimal.Length; i++)
			{
				currentDigit = hexadecimal[i];
				int curr = 0;
				switch (currentDigit)
				{
					case '0': curr = 0; break;
					case '1': curr = 1; break;
					case '2': curr = 2; break;
					case '3': curr = 3; break;
					case '4': curr = 4; break;
					case '5': curr = 5; break;
					case '6': curr = 6; break;
					case '7': curr = 7; break;
					case '8': curr = 8; break;
					case '9': curr = 9; break;
					case 'A': curr = 10; break;
					case 'B': curr = 11; break;
					case 'C': curr = 12; break;
					case 'D': curr = 13; break;
					case 'E': curr = 14; break;
					case 'F': curr = 15; break;

				}
				var currentResult = curr * Math.Pow(16, i);
				result += (int)currentResult;
			}
			
			Console.WriteLine(result);
			
		}
	}
}
