using Microsoft.VisualStudio.TestTools.UnitTesting;
using _05Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Exercise.Tests
{
	[TestClass()]
	public class ProgramTests
	{
		[TestMethod()]
		public void IsBiggerThanNeighboursTestMiddleIndex()
		{
			// Arrange
			int[] arrTest = new int[] { 1, 2, 3, 2 };
			bool expected = true;
			// Act
			bool actual = _05Exercise.Program.IsBiggerThanNeighbours(arrTest, 2);
			// Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod()]
		public void IsBiggerThanNeighboursTestStartIndex()
		{
			// Arrange
			int[] arrTest = new int[] { 1, 2, 3, 2 };
			bool expected = false;
			// Act
			bool actual = _05Exercise.Program.IsBiggerThanNeighbours(arrTest, 0);
			// Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod()]
		public void IsBiggerThanNeighboursTestEndIndex()
		{
			// Arrange
			int[] arrTest = new int[] { 1, 2, 3, 2 };
			bool expected = false;
			// Act
			bool actual = _05Exercise.Program.IsBiggerThanNeighbours(arrTest, 0);
			// Assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod()]
		[ExpectedException(typeof(IndexOutOfRangeException))]
		public void IsBiggerThanNeighboursTestIndexOutOfRangeException()
		{
			// Arrange
			int[] arrTest = new int[] { 1, 2, 3, 2 };
			// Act
			bool actual = _05Exercise.Program.IsBiggerThanNeighbours(arrTest, 5);
		}
	}
}