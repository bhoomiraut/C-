using System;
using System.Diagnostics;

namespace Stopwatch1
{
    class SW
{
    static void Main(string[] args)
    {
        int n;

        Stopwatch stopwatch = new Stopwatch();
        Console.WriteLine("\nEnter the value of n: ");
        n = Convert.ToInt32(Console.ReadLine());
        stopwatch.Start();        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(".NET");
        }

        stopwatch.Stop();
        Console.WriteLine("\nTime Elapsed :" + stopwatch.Elapsed);
        Console.ReadLine();
    }
}
}
