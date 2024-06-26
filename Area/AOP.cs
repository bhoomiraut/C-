using System;

namespace Polygon
{
    class AOP
    {
        static void Main()
        {
            double n, l, r, Area;

            Console.WriteLine("Enter the no. of sides: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the value of length: ");
            l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of radius: ");
            r = Convert.ToInt32(Console.ReadLine());

            Area= (n/2)*l*r;
            Console.WriteLine("Area of Triangle= "+Area);   

        }
    }
}
