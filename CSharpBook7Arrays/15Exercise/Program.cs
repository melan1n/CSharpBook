using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			//initialize a variable for zero index ascii code of 'a' 
			int zeroIndexCapitals = (int)'A'; //65
			int zeroIndexSmalls = (int)'Z' - (int)'A'; //25


			//read a word from console
			var word = Console.ReadLine();
			//loop word for each char get ASCCI code, subtract code of 'a'; print out result
			foreach (var character in word)
			{
				int index;
				if ((int)character >= 65 && (int)character <= 90)
				{
					index = (int)character - zeroIndexCapitals;
				}
				else
				{
					index = zeroIndexSmalls + (int)character - (int)'a'; 
				}
				Console.Write("{0,4} ", index);
			}

		}
	}
}
