using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = int.Parse(Console.ReadLine());
			var b = int.Parse(Console.ReadLine());
			int count = 0;
			for (int i = a; i <= b; i++)
			{
				
				if (i%5 == 0)
				{
					count++;
				}
			}
			Console.WriteLine(count);
		}
	}
}
