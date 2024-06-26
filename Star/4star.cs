using System;

namespace Star_
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
        }
    }
}