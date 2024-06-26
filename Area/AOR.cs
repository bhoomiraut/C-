using System;

namespace Area_of_Rectangle
{
    class AOR
    {
        static void Main()
        {
            double w, l, Area;

            Console.WriteLine("Enter the value of width: ");
            w = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the value of length: ");
            l = Convert.ToInt32(Console.ReadLine());

            Area= w*l;
            Console.WriteLine("Area of Triangle= "+Area);   

        }
    }
}
