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
			var n = int.Parse(Console.ReadLine());
			var p = int.Parse(Console.ReadLine());
			int i = 1;

			var binaryN = Convert.ToString(n, 2);
			var binaryI = Convert.ToString(i, 2);

			var mask = i << p;
			Console.WriteLine((n & mask) != 0 ? 1 : 0);
		}
	}
}
