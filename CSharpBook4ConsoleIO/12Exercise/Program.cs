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
			float currentSum = 0;
			float oldSum = 1;
			int i = 2;
			
			while (true)
			{
				
				if (i%2==1)
				{
					currentSum = oldSum - (float)1 / i;
				}
				else
				{
					currentSum = oldSum + (float)1 / i;
				}
				
				if (Math.Abs(currentSum - oldSum) < 0.001)
				{
					break;
				}
				else
				{
					oldSum = currentSum;
					i++;
				}
			}
			Console.WriteLine("{0:F3}", oldSum);
		}
	}
}
