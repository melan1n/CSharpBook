using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = int.Parse(Console.ReadLine());
			var b = int.Parse(Console.ReadLine());

			int aTemp = a;
			int bTemp = b;
			int result = 0;

			while (aTemp != bTemp)
			{
				

				result = Math.Max(aTemp, bTemp) - Math.Min(aTemp, bTemp);
				if (aTemp>bTemp)
				{
					aTemp = result;
				}
				else
				{
					bTemp = result;
				}
			}
			Console.WriteLine("GCD: {0}", aTemp);
			Console.WriteLine("LCM: {0}", Math.Abs(a*b)/ aTemp);
		}
	}
}
