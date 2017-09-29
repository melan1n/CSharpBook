using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Exeercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var result = "Prime";

			for (int i = 2; i < Math.Sqrt(n); i++)
			{
				if (n%i == 0 && i != n)
				{
					result = "Not Prime";
				}
			}

			Console.WriteLine(result);
		}
	}
}
