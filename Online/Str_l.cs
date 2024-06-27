using System;
namespace str_length
{
    public class str_length
    {
        public static void Main(string[] args)
        {
            string name;
            Console.WriteLine("\nEnter the string: ");
            name = Console.ReadLine();
            int length = name.Length;
            Console.WriteLine("\nLength of string: "+ length + "\n");
        }
        
    }
}