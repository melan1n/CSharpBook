using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var hex = int.Parse(Console.ReadLine());
			var fract = double.Parse(Console.ReadLine());
			var negFract = double.Parse(Console.ReadLine());

			Console.WriteLine("{0,-10:X}{1,-10:F2}{2,-10:F2}", hex, fract, negFract);
		}
	}
}
