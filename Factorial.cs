using System;

namespace Facto
{
    class fact
    {
        static void Main()
        {
            int a, n, f=1;
            Console.WriteLine("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            for(a=1 ; a<n+1 ; a++)
            {
                f=f*a;
            }
            Console.WriteLine("Factorial of "+ n + " is: " +f);
        }
    }
}
