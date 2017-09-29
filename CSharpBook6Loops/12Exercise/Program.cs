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
			var num = int.Parse(Console.ReadLine());
			var result = "";

			while (num>0)
			{
				
				var bit = Convert.ToString(num % 2);
				result = result.Insert(0, bit);
				num = num / 2;
			}
			Console.WriteLine(result);
		}
	}
}
