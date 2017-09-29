using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			if (n == 1)
			{
				Console.WriteLine("0");
			}
			else if (n == 2)
			{
				Console.WriteLine("1");
			}
			else		
			{
				int f1 = 0;
				int f2 = 1;
				var sumN_1 = 1;
				int sumN = 0;

				for (int i = 3; i <= n; i++)
				{
					int fCurr = f1 + f2;
					sumN = sumN_1 + fCurr;
					f1 = f2;
					f2 = fCurr;
					sumN_1 = sumN;
				}
				Console.WriteLine(sumN);
			}
			
		}
	}
}
