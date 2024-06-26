using System;

namespace Area_of_Triangle
{
    class AOT
    {
        static void Main()
        {
            double b, h, Area;

            Console.WriteLine("Enter the value of height: ");
            h = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the value of base: ");
            b = Convert.ToInt32(Console.ReadLine());

            Area= 0.5*(h*b);
            Console.WriteLine("Area of Triangle= "+Area);   

        }
    }
}
