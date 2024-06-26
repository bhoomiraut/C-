using System;

namespace Star_s
{
    class Star
    {
        static void Main(string[] args)
        {
            int i, j;

            for(i=1; i<=5; i++)
            {
                for(j=5; j>=i; j--)
                {
                    Console.Write(" *");
                }
                Console.Write("\n ");
            }
        }
    }
}