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
			double result = 0;

			for (int i = 1; i <= n; i++)
			{
				result += (n / Math.Pow(5, i));
			}
			Console.WriteLine(Math.Floor(result));
		}
	}
}
