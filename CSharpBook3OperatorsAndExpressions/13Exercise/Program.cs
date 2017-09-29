using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var p = int.Parse(Console.ReadLine());
			var v = int.Parse(Console.ReadLine());

			var binaryN = Convert.ToString(n, 2);
			int i = 1;
			var binaryI = Convert.ToString(i, 2);

			var mask = i << p;
			if ((n & mask) != 0)
			{
				n = (n & ~mask);
			}
			else
			{
				n = (n | mask);
			}
			

			//35             00100011
			//~(1<<p)        11011111
			//binaryNNew(&)  00000011

			//35             00100011
			//(1<<p)		 00000100
			//binaryNNew(|)  00100111

			Console.WriteLine(n);
			//Use bitwise operations by analogy with the previous two problems. 
			//You can reset the bit at position p in the number n as follows: n = n & (~(1 << p));
			//You can set bits in the unit at position p in the number n as follows: n = n | (1 << p);
			//Think how you can combine the above two hints.

		}
	}
}
