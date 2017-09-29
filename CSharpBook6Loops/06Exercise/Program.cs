using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var k = int.Parse(Console.ReadLine());
			var nFact = 1;
			var kFact = 1;

			for (int i = 1; i <= n; i++)
			{
				nFact *= i;
			}
			for (int j = 1; j <= k; j++)
			{
				kFact *= j;
			}

			Console.WriteLine((double)(nFact/kFact));
		}
	}
}
