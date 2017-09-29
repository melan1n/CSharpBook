using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var v = int.Parse(Console.ReadLine());
			var p = int.Parse(Console.ReadLine());

			var binaryV = Convert.ToString(v, 2);

			int i = 1;
			var binaryI = Convert.ToString(i, 2);

			var mask = i << p;

			Console.WriteLine((v&mask) == 0 ? "False" : "True");
		}
	}
}
