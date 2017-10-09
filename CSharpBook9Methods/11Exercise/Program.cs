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
			Console.WriteLine("Please choose a task:");
			Console.WriteLine("1 - Reverse Number Digits");
			Console.WriteLine("2 - Average of Number Sequence");
			Console.WriteLine("3 - Solve the Equation a * x + b = 0");
			string userInput = Console.ReadLine();
			while (userInput != "1" && userInput != "2" && userInput != "3")
			{
				Console.WriteLine("Invalid task. Please try again!");
				userInput = Console.ReadLine();
			}
			string userPrompt = string.Empty;
			switch (userInput)
			{
				case "1": userPrompt = "Please type in a number from 0 to 50 000 000."; break;
				case "2": userPrompt = "Please type in a sequence of numbers separated by an interval."; break;
				case "3": userPrompt = "Please type in coeficients 'a' and 'b' separated by an interval."; break;
			}
			Console.WriteLine(userPrompt);
			if (userInput == "1")
			{
				ReverseNumberDigits();
			}
			else if (userInput == "2")
			{
				GetAverageOfSequence();
			}
			else if (userInput == "3")
			{
				SolveLinearEquation();
			}
		}

		private static void SolveLinearEquation()
		{
			double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			double a = arr[0];
			double b = arr[1];
			while (a==0)
			{
				Console.WriteLine("Coefficient 'a' should be non-zero. Please type in different input.");
				arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
				a = arr[0];
				b = arr[1];
			}
			double x = -b / a;
			Console.WriteLine($"x = {x}");
		}

		private static void GetAverageOfSequence()
		{
			int result = 0;
			IEnumerable<string> arr = Console.ReadLine().Split(' ');
			arr.Select(str => int.TryParse(str, out result)).ToArray();
			while (result == 0)
			{
				Console.WriteLine("Please input a valid number sequence.");
				arr = Console.ReadLine().Split(' ');
				arr.Select(str => int.TryParse(str, out result)).ToArray();
			}
			int[] numbersArray = arr.Select(int.Parse).ToArray();
			Console.WriteLine($"The average of the sequence {string.Join(" ", arr)} is: " +
				$"{(double)numbersArray.Sum()/numbersArray.Length}");
		}

		private static void ReverseNumberDigits()
		{
			int number = int.Parse(Console.ReadLine());
			while (number > 50000000 && number < 0)
			{
				Console.WriteLine("Number cannot exceed 50 000 000. Please type in a valid number.");
				number = int.Parse(Console.ReadLine());
			}
			char[] arr = number.ToString().ToCharArray();
			Array.Reverse(arr);
			Console.WriteLine(String.Join("", arr));
		}
	}
}
