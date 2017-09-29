using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var x = int.Parse(Console.ReadLine());

			double sum = 1;
			var nFact = 1;

			for (int i = 1; i <= n; i++)
			{
				nFact *= i;
				sum += (nFact / (Math.Pow(x, i)));
			}
			Console.WriteLine(sum);
		}
	}
}
