using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10EXERCISE
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			for (int rows = 0; rows < n; rows++)
			{
				for (int col = rows + 1 ; col < rows + 1 + n ; col++)
				{
					Console.Write("{0} ", col);
				}
				Console.WriteLine();
			}
		}
	}
}
