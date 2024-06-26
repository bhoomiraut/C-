using System;

namespace Swap3
{
    class s3
    {
        static void Main()
        {
            int a, b;

            Console.WriteLine("Enter the value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the value of b: ");
            b = Convert.ToInt32(Console.ReadLine());

            a*=b;
            b=a/b;
            a/=b;

            Console.WriteLine("Swaped value of a: "+a);
            Console.WriteLine("Swaped value of b: "+b);
        }
    }
}
