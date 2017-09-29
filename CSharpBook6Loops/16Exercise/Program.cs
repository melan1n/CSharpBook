using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			Random rnd = new Random();
			int[] array = new int[n];
			for (int i = 0; i < n; i++)
			{
				array[i] = i+1;
			}
			for (int k = 0; k < n; k++)
			{
				int swap1Index = rnd.Next(0, n);
				int swap2Index = rnd.Next(0, n);
				int swaptemp = array[swap1Index];
				array[swap1Index] = array[swap2Index];
				array[swap2Index] = swaptemp;
			}
			for (int j = 0; j < n; j++)
			{
				Console.Write("{0} ", array[j]);
			}
			
			//Random rnd = new Random();
			//for (int ctr = 0; ctr < n; ctr++)
			//{
			//	Console.Write("{0,3}   ", rnd.Next(0, n + 1));
			//}
		}
	}
}
