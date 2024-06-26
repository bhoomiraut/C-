using System;

namespace Star_tb
{
    class star
    {
        static void Main(string[] args)
        {
            int i, j;

            for(i=4; i>=1; i--)
            {
                for(j=4; j>=i; j--)
                {
                    Console.Write(" *");
                }
                Console.Write("\n");
            }

            for(i=1; i<=3; i++)
            {
                for(j=3; j>=i; j--)
                {
                    Console.Write(" *");
                }
                Console.Write("\n");
            }
        }
    }
}