
using System;
namespace Lower_Uppercase
{
	class l_ucase {
	public static void Main(string[] args)
	{
		string str = "Bhoomi Ganesh Raut";

		// string converted to lower case
		string lowerstr = str.ToLower();
        Console.WriteLine("\nLowercase: " +lowerstr);
        string upperstr = str.ToUpper();
        Console.Write("\nUppercase: " +upperstr);
        Console.Write("\n");
        Console.ReadLine();
	}
}
}

