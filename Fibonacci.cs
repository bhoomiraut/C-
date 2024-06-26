using System;

namespace Fibonacci
{
    public class fibo
    {
        public static void Main(string[] args)
        {
            int a=0,b=1,c,i,num;   
            Console.WriteLine("Enter the number of elements: ");
            num= Convert.ToInt32(Console.ReadLine());
            Console.Write(a+" "+b+" ");    
            for(i=2;i<num;++i) 
            {    
                c=a+b;    
                Console.Write(c+" ");    
                a=b;    
                b=c;
            }
        }
    }
}    