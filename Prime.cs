using System;
namespace Prime_No {
   class prime {
        static void Main() {
        int n, a = 0;
        Console.WriteLine("Enter the number to check whether it is prime or not: ");
        n= Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++) 
        {
            if (n % i == 0) 
            {
               a++;
            }
        }
        if (a == 2) 
        {
            Console.WriteLine("{0} is a Prime Number", n);
        } else {
            Console.WriteLine("Not a Prime Number");
        }
      }
   }
}