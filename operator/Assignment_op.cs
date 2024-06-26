using System;

namespace Assignment_Op
{
    class Ass_op
    {
        static void Main()
        {
            int a, b=55, c=50;
            int d = 45;

            Console.WriteLine("Enter your current weight: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a < b && a > c )
            {
                a-=b;
                Console.WriteLine("Your weight fits into secondary group & your weight is less than 55 by: "+a);
            }
            else if (a < c && a > d) 
            {
                a-=c;
                Console.WriteLine("Your weight fits into primary group but, your weight is less than 50 by: "+a);
            }
            else if (a<d)
            {   
                a/=b;
                a+=d;
                Console.WriteLine("Wow!! You meet your expected weight count: ");
                Console.WriteLine("You need to loose/ gain the weight by: "+a);   
            }
            else if(a<)

        }
    }
}
