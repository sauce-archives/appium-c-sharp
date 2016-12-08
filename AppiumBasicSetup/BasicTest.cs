using NUnit.Framework;
using System;
namespace AppiumBasicSetup
{
	[TestFixture()]
	public class BasicTest
	{
		[SetUp()]
		public void SetUp()
		{
			Console.Write("Setting up the test");
		}

		[Test()]
		public void FirstTest()
		{
			Console.Write("Running the first test");
		}
			       

		[Test()]
		public void TestCase()
		{
			Console.Write("Running the second test");
		}

		[TearDown()]
		public void TearDown()
		{
			Console.Write("Tearing down the test");
		}
	}
}
