using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			//create a sorted array
			int[] myArray = new int[] {4, 13, 2, 1, 5, 6, 0, 8, 7, 9};
			Array.Sort(myArray);
			//Set L to 0 and R to n − 1.
			var T = int.Parse(Console.ReadLine());
			var L = 0;
			var R = myArray.Length - 1;
			//If L > R, the search terminates as unsuccessful.
			while (L <= R)
			{
				//Set m(the position of the middle element) to the floor(the largest previous integer) of(L + R) / 2.
				var m = (L + R) / 2;
				//If Am<T, set L to m +1 and go to step 2.
				if (myArray[m] < T)
				{
					L = m + 1;
				}
				//If Am > T, set R to m − 1 and go to step 2.
				else if (myArray[m] > T)
				{
					R = m - 1;
				}
				//Now Am = T, the search is done; return m.

				else if (myArray[m] == T)
				{
					Console.WriteLine("Result Index is {0}", m);
					break;
				}
			}
			if (L>R)
			{
				Console.WriteLine("No result");
			}
			
			
			
				
			
		}
	}
}
