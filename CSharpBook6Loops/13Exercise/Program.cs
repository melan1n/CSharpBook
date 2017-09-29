using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var binary = Console.ReadLine();
			char[] array = binary.ToCharArray();
			Array.Reverse(array);
			binary = new string(array);
			int result = 0;

			for (int i = 0; i < binary.Length; i++)
			{
				int curr = 0;
				if (binary[i] == '0')
				{
					curr = 0;
				}
				else
				{
					curr = (int)Math.Pow(2, i);
				}
				
				result += curr;
			}
			Console.WriteLine(result);
		}
	}
}
