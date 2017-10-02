using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			bool[] array = new bool[(int)Math.Sqrt(n)];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = true;
			}
			for (int i = 2; i < array.Length; i++)
			{
				if (array[2] == true)
				{
					for (int j = i*i ; j < array.Length; j=j+i)
					{
						array[j] = false;
					}
				}
			}
			for (int m = 2; m < array.Length; m++)
			{
				if (array[m] == true)
				{
					Console.Write($"{m} ");
				}
			}

		}
	}
}
