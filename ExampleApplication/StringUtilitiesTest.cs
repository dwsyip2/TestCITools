using System;
using NUnit.Framework;

namespace ExampleApplication
{
	[TestFixture()]
	public class StringUtilitiesTest
	{
		[Test()]
		public void combineArrayStringWithDelimeterTest()
		{
			string[] myStrings = { "DP1", "is", "cool" };
			string delimiter = " ";
			StringUtilities myUtility = new StringUtilities();
			string result = myUtility.combineArrayStringWithDelimiter(myStrings, delimiter);
			Assert.AreEqual("DP1 is cool", result);
		}

		[Test()]
		public void replaceSpacesInStringByHyphensTest()
		{
			string myString = "DP1 is cool";
			StringUtilities myUtility = new StringUtilities();
			string result = myUtility.replaceSpacesInStringByHyphens(myString);
			Assert.AreEqual("DP1-is-cool", result);
		}

	}
}
