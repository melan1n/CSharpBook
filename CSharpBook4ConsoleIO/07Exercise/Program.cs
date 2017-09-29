using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			
			int sum = 0;
			for (int i = 0; i < 5; i++)
			{
				bool parseSuccess = int.TryParse(Console.ReadLine(), out int num);
				if (parseSuccess == true)
				{
					sum = sum + num; 
				}
				else
				{
					Console.WriteLine("Invalid Number!");
					break;
				}
				if (i == 4)
				{
					Console.WriteLine("{0}", sum);
				}

			}

		}
	}
}
