using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var s = Console.ReadLine();
			int[] array = s.Split(' ').Select(str => int.Parse(str)).ToArray();

			var maxOccurrenceEver = 1;
			var maxOccurringInt = int.MinValue;

			for (int i = 0; i < array.Length; i++)
			{
				var num = array[i];
				var maxOccurrence = 1;
				for (int j = i+1; j < array.Length; j++)
				{
					if (array[j] == num && array[j]!= int.MinValue)
					{
						maxOccurrence++;
						array[j] = int.MinValue;
					}
				}
				if (maxOccurrence > maxOccurrenceEver)
				{
					maxOccurrenceEver = maxOccurrence;
					maxOccurringInt = num;
				}
			}
			Console.WriteLine("Max occurence: {0}", maxOccurrenceEver);
			Console.WriteLine("Max occurring number: {0}", maxOccurringInt);

		}
	}
}
