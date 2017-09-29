using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var a = int.Parse(input[0].ToString());
			var b = int.Parse(input[1].ToString());
			var c = int.Parse(input[2].ToString());
			var d = int.Parse(input[3].ToString());

			Console.WriteLine("{0}", a+b+c+d);
			Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
			Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
			Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
		}
	}
}
