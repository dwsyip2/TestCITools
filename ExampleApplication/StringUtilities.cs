using System;
namespace ExampleApplication
{
	public class StringUtilities
	{
		public StringUtilities()
		{
		}
		public string combineArrayStringWithDelimiter(string[] stringArray,
		string delimiter)
		{
			string str = default(string);
			try
			{
				for (int i = 0; i < stringArray.Length - 1; i++)
				{
					str += stringArray[i] + delimiter;
				}
				str += stringArray[stringArray.Length-1];
			}
			catch (ArgumentOutOfRangeException)
			{

			}
			return str;
		}
		public string replaceSpacesInStringByHyphens(string aString)
		{
			string[] stringArray = aString.Split(' ');
			return combineArrayStringWithDelimiter(stringArray, "-");
		}
	}
}
