using System;

namespace Receipt
{
    public class Details_a
    {
        public string name, branch, yr;
        public int usn, e = 100000, ex = 1000, l = 1200, h = 50000, lab = 10000, p_c = 10000, sum;

        public void GetDetails()
        {
            Console.WriteLine("\nStudent Name: ");
            name = Console.ReadLine();
            Console.WriteLine("USN: ");
            usn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Branch: ");
            branch = Console.ReadLine();
            Console.WriteLine("Year: ");
            yr = Console.ReadLine();
        }
    }

    public interface A
    {
        void Display();
    }

    public class Display1 : Details_a, A
    {
        public void Display()
        {
            Console.WriteLine("\n*******************************************************************************************************\n");
            Console.WriteLine("\t \t \t \t SANJIVANI COLLEGE OF ENGINEERING \t \t \t \t ");
            Console.WriteLine("*******************************************************************************************************\n");
            Console.WriteLine("\t \t \t \t ~Academic Fee Receipt~ \t \t \t \n");
            Console.WriteLine("*******************************************************************************************************\n");
            DateTime dt = DateTime.Now;
            
            Console.WriteLine("\n\t\t\t\t\t\t\tDate and Time is: " + dt);
            Console.Write("\nName: " +name );
            Console.Write("\nUSN: " +usn );
            Console.Write("\nBranch: " +branch );
            Console.Write("\nYear: " +yr ); 
            Console.Write("\nEntrance Fee: " + e + "$");
            Console.Write("\nExam Fee: " + ex + "$");
            Console.Write("\nLibrary Charges: " + l + "$");
            Console.Write("\nHostel Fee: " + h + "$");
            Console.Write("\nLaboratory charges: " + lab + "$");
            Console.Write("\nProjects & Classes: " + p_c + "$");
            sum = e + ex + l + h + lab + p_c;
            Console.Write("\n*******************************************************************************************************\n\n");
            Console.Write("Total: " + sum + "$");
            Console.Write("\n*******************************************************************************************************\n\n");
            Console.Write("\n\t\t\t\t\t        THANK YOU!!            ");
        }
    }

    public class Inherit
    {
        public static void Main(string[] args)
        {
            Display1 d1 = new Display1();
            d1.GetDetails();  // Calling the method to print the projects
            d1.Display();  // Calling the method to print the projects
        }
    }
}
