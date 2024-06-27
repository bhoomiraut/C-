using System;

namespace Billing_sw
{
    class Bill{
        public static void Main(string[] args)
        {
            int n, choice, i, j, qty;
            double price, total, mul;
            string name;

            
            
                Console.WriteLine("\n************************Bhoomi's League************************");
                Console.WriteLine("\n1. Add Iteam \n2.View Bill \n3. Exit");
                Console.WriteLine("\n****************************");
                Console.WriteLine("Enter your choice: ");
                do
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch(choice)
                    {
                        case 0:
                            Console.Write("\nEnter Valid Choice :)");
                            break;
                        
                        case 1:
                            Console.Write("Enter No. of Iteams to be added: ");
                            n= Convert.ToInt32(Console.ReadLine());
                            for(i=1; i<=n; i++)
                            {   
                                Console.Write("Enter the Iteam Name "+i+" : ");
                                name = Console.ReadLine();
                                Console.Write("Enter the Iteam Price "+i+" : ");
                                price = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter the Iteam Quantity "+i+" : ");
                                qty = Convert.ToInt32(Console.ReadLine());
                            }

                }
        }
    }
}