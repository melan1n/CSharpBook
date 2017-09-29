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
			var s = Console.ReadLine();
			int[] array = s.Split(' ').Select(str => int.Parse(str)).ToArray();

			for (int i = 0; i < array.Length; i++)
			{
				for (int j = i+1; j < array.Length; j++)
				{
					if (array[i]>array[j])
					{
						var temp = array[i];
						array[i]= array[j];
						array[j] = temp;
					}
				}
			}
			for (int k = 0; k < array.Length; k++)
			{
				Console.Write("{0} ", array[k]);

			}
		}
	}
}
