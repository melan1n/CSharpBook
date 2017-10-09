using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Exercise
{
	public class Program
	{
		static void Main(string[] args)
		{
			long[] arr = new long[] { 1, 2, 3, 1, 5, 1};
			Console.WriteLine(getCountOfOccurences(arr, 1));

		}

		public static long getCountOfOccurences(long[] arr, long value)
		{
			long countOfOccurences = 0;
			foreach (var number in arr)
			{
				if (number == value)
				{
					countOfOccurences++;
				}
			}
			return countOfOccurences;

		}
	}
}
