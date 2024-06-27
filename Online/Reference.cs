using System;

namespace Reference
{
     class refer
     {
         static void Main(string[] args)
         {
             int x = 10;
             Console.WriteLine("Variable Value Before Calling the Method: ", x);
             Multiplication(ref x);
             Console.WriteLine("Variable Value After Calling the Method: ", x);
             Console.WriteLine("Press Enter Key to Exit..");
             Console.ReadLine();
         }
         public static void Multiplication(ref int a)
         {
              a *= a;
              Console.WriteLine("Variable Value Inside the Method: ", a);
         }
     }
}