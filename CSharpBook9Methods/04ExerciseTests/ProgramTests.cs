using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Exercise.Tests
{
	[TestClass()]
	public class ProgramTests
	{
		[TestMethod()]
		public void getCountOfOccurencesTestStraightScenario()
		{
			// Arrange
			long[] arrTest = new long[] {1, 2, 3, 4, 5, 1 };
			// Act
			long result = _04Exercise.Program.getCountOfOccurences(arrTest , 1);
			// Assert
			Assert.IsTrue(result == 2);
		}
		[TestMethod()]
		public void getCountOfOccurencesTestOverflow()
		{
			// Arrange
			long[] arrTest = new long[] { 10000000000, 1 };
			long expected = 1;
			// Act
			long actual = _04Exercise.Program.getCountOfOccurences(arrTest, 10000000000);
			// Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod()]
		[ExpectedException(typeof(NullReferenceException))]
		public void getCountOfOccurencesTestNullArray()
		{
			
			_04Exercise.Program.getCountOfOccurences(null, 10000000000);
			
		}
	}
}