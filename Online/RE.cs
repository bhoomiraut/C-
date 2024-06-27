
using System;
using System.Text.RegularExpressions;

class GFG {
	
		static void Main(string[] args)
	{
		
		string[] str = {"9925612824",
		"823878313", "02812451830"};
		
		foreach(string s in str)
		{
			Console.WriteLine("{0} {1} a valid mobile number.", s, 
						isValidMobileNumber(s) ? "is" : "is not");
		}
		
		Console.ReadKey();
	}
	public static bool isValidMobileNumber(string inputMobileNumber)
	{
		string strRegex = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]
				{2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";
		
		// Class Regex Represents an
		// immutable regular expression.
		// Format			 Pattern
		// xxxxxxxxxx		 ^[0 - 9]{ 10}$
		// +xx xx xxxxxxxx	 ^\+[0 - 9]{ 2}\s +[0 - 9]{ 2}\s +[0 - 9]{ 8}$
		// xxx - xxxx - xxxx ^[0 - 9]{ 3} -[0 - 9]{ 4}-[0 - 9]{ 4}$
		Regex re = new Regex(strRegex);
		
		if (re.IsMatch(inputMobileNumber)) 
			return (true);
		else
			return (false);
	}
}
