using System;
namespace R_Array
{
    class arr
    {
        static void Main()
        {
            int n;
            Console.WriteLine("\nEnter the Size of Array: ");
            n= Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[n];
            Console.WriteLine("\nEnter the values in Array: ");
            for(int i=0; i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nReverse Array: ");
            for(int i=n-1; i>=0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}