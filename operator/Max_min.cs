using System;

namespace Max_min
{
    class Mm
    {
        static void Main()
        {
            int a, b;

            Console.WriteLine("Enter the value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the value of b: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("A is Greater than B");
            }
            else if (b > a) 
            {
                Console.WriteLine("B is Greater than A");
            }
            else
            {
                Console.WriteLine("A is equal to B");
            }
        }
    }
}
