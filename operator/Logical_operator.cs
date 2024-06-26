using System;

namespace Logical_Relatrional
{
    class Logical_Rel
    {
        static void Main()
        {
            int a;
            Console.WriteLine("Enter your Age: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a >= 1 && a <= 5)
            {
                Console.WriteLine("Not Eligible for the Admission");
            }
            else if (a > 5 || a == 6) // Adjusted the range for clarity
            {
                Console.WriteLine("Eligible for the Admission");
            }
            else if (a >= 18 && a <= 32) // Corrected condition for UPSC eligibility
            {
                Console.WriteLine("You are Eligible for UPSC");
            }
            else
            {
                Console.WriteLine("Does not fit into any category");
            }
        }
    }
}
