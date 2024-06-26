using System; 
namespace Inheritance
{
    public class Employee_Details
    {  
        public string Name = "Mahi";
        public int ID = 1;  // Corrected the ID declaration
        public float salary = 40000;  
    }  

    public class Promotion: Employee_Details
    {
        public double WH = 9.5;
    }

    public class Bonus: Employee_Details
    {  
        public float bonus = 10000;  
    }      

    interface A 
    {
        void fun1();
    }

    interface B 
    {
        void fun2();
    }
   
    public class Review: Bonus, A, B
    {  
        public string status = "Selected"; 
        public string dept = "S/w Development";  // Moved dept to class level
        public string Pro = "\n1. Smart City \n2. Auto Call";  // Moved Pro to class level

        public void fun1()
        {
            Console.WriteLine("*************Employee Department************");
            Console.WriteLine("Department: " + dept);
        } 

        public void fun2()
        {
            Console.WriteLine("*************Projects************");
            Console.WriteLine("Projects: " + Pro);
        } 
    }  

    class TestInheritance
    {  
        public static void Main(string[] args)  
        {  
            Review r1 = new Review(); 
            Promotion p1 = new Promotion(); 

            Console.WriteLine("Name: " + r1.Name);  
            Console.WriteLine("ID: " + r1.ID);  
            Console.WriteLine("Working Hours: " + p1.WH + " hrs");  
            Console.WriteLine("Bonus: " + r1.bonus);  
            r1.fun1();  // Calling the method to print the department
            r1.fun2();  // Calling the method to print the projects
            Console.WriteLine("Status: " + r1.status);  
        }  
    }
}
