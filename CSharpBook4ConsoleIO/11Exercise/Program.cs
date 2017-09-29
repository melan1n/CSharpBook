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
			ulong num1 = 0;
			ulong num2 = 1;
			Console.WriteLine(num1);
			Console.WriteLine(num2);

			for (int i = 0; i < 98; i++)
			{
				ulong num = num1 + num2;
				Console.WriteLine(num);
				num1 = num2;
				num2 = num;
			}
		}
	}
}
