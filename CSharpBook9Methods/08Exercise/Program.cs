using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] number1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int[] number2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int[] sum = SumLongNumbers(number1, number2);
			Console.WriteLine(String.Join("", sum.Reverse()));
		}

		private static int[] SumLongNumbers(int[] number1, int[] number2)
		{
			int[] sum = new int[Math.Max(number1.Length, number2.Length) + 1];
			sum[0] = (number1[0] + number2[0]) % 10;
			int remainder = (number1[0] + number2[0]) / 10;
			for (int i = 1; i < Math.Max(number1.Length, number2.Length); i++)
			{
				sum[i] = (number1[i] + number2[i] + remainder) % 10;
				remainder = (number1[i] + number2[i] + remainder) / 10;
			}
			if (remainder > 0)
			{
				sum[Math.Max(number1.Length, number2.Length)] = remainder;
			}
			return sum;
		}
	}
}
