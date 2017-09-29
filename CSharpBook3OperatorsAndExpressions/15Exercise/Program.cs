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
			var num = Int32.Parse(Console.ReadLine());
			Console.WriteLine(Convert.ToString(num, 2));

			int bit3 = (num >> 3) & 1; //value of bit on pos 3 (0 or 1)
			int bit24 = (num >> 24) & 1; //value of bit on pos 24 (0 or 1)
			num = num & (~(1 << 24)) | (bit3 << 24);
			num = num & (~(1 << 3)) | (bit24 << 3);

			int bit4 = (num >> 4) & 1; //value of bit on pos 4 (0 or 1)
			int bit25 = (num >> 25) & 1; //value of bit on pos 25 (0 or 1)
			num = num & (~(1 << 25)) | (bit4 << 25);
			num = num & (~(1 << 4)) | (bit25 << 4);


			int bit5 = (num >> 5) & 1; //value of bit on pos 4 (0 or 1)
			int bit26 = (num >> 26) & 1; //value of bit on pos 25 (0 or 1)
			num = num & (~(1 << 26)) | (bit5 << 26);
			num = num & (~(1 << 5)) | (bit26 << 5);

			Console.WriteLine(Convert.ToString(num, 2));

		}
	}
}
