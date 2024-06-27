using System;
namespace Pass_by_value
{
    class pass
    {
        static void Cube(int x)
        {
            x = x * x * x;
            Console.WriteLine("Value Within the Cube method : "+ x);
        }
        static void Main()
        {
            int num = 5;
            Console.WriteLine("Value Before the Method is called : "+ num);
            Cube(num);
            Console.WriteLine("Value After the Method is called : "+ num);
            Console.ReadKey();
        }
    }
}

