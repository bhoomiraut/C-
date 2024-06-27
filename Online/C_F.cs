using System;

namespace Temperature_c
{
    class temp
    {
        static void Main(string[] args)
        {
            double fahrenheit, celsius;

            Console.WriteLine("\nEnter the temperature in Celsius: ");
            string input = Console.ReadLine();
            
            if (double.TryParse(input, out celsius))
            {
                Console.WriteLine("Celsius: " + celsius);

                fahrenheit = (celsius * 9) / 5 + 32;
                Console.WriteLine("Fahrenheit: " + fahrenheit);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }

            Console.ReadLine();
        }
    }
}
