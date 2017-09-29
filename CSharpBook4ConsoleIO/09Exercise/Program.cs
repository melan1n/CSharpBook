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
			var result = int.MinValue;

			for (int i = 0; i < 5; i++)
			{
				var num = int.Parse(Console.ReadLine());
				if (num>result)
				{
					result = num;
				}
			}
			Console.WriteLine(result);
		}
	}
}
