using System;
using System.Collections.Generic;
namespace Sort
{
    public class sort_names
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>();
            Console.WriteLine("Enter names:");

            while (true)
            {
                string str = Console.ReadLine();
                if (str.ToLower() == "exit")
                {
                    break;
                }
                names.Add(str);
            }

            Console.WriteLine("\n\nNames Before Sorting");
            foreach (string name in names) //foreach is used for iterating the collections.
            {
                Console.WriteLine(name);
            }

            names.Sort();
            Console.WriteLine("\nNames After Sorting");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}