using System;

namespace Star_tb
{
    class star
    {
        static void Main(string[] args)
        {
            int i, j, k;

            for(i=4; i>=1; i--)
            {
                for(j=1; j<=i; j++)
                {
                    Console.Write(" ");
                }
                for(k=4; k>=i; k--)
                {
                    Console.Write(" *");
                }
                Console.Write("\n");
            }

            for(i=1; i<=3; i++)
            {
                for(j=0; j<=i; j++)
                {
                    Console.Write(" ");
                }
                for(k=3; k>=i; k--)
                {
                    Console.Write(" *");
                }
                Console.Write("\n");
            }
        }
    }
}