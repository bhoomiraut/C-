using System;
namespace Swap_nos
{
    class swap{

        static int a=10, b=20;
        static void Main(string [] args){
            int c;
            c= a;
            a = b;
            b = c;
        
            Console.Write("\na= "+a);
            Console.Write("\nb= "+b);
        }
    }
}