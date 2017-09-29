using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var arrayS = Console.ReadLine();
			int[] array = arrayS.Split(' ').Select(str => int.Parse(str)).ToArray();
			var s = int.Parse(Console.ReadLine());

			int startIndex = 0;
			int endIndex = 0;

			for (int i = 0; i < array.Length; i++)
			{
				startIndex = i;
				int sum = 0;
				for (int j = i; j < array.Length; j++)
				{
					sum += array[j];
					if (sum == s)
					{
						endIndex = j;
						break;
					}
					else if (sum > s)
					{
						break;
					}
				}
				if (sum == s)
				{
					break;
				}
			}
			for (int k = startIndex; k <= endIndex; k++)
			{
				Console.Write("{0} ", array[k]);
			}
		}
	}
}
