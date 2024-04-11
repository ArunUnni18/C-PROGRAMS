using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_programs
{
    public class Class1
    {
       public String name = "Arun", address = "Simplogics";
       public long phoneno = 7994554097;
        public int age = 25, mark1 = 78, mark2 = 75, mark3 = 80,avg;

        public static void Main()
        {
            StudentDetails();
            Average();

        }
        public static void StudentDetails()
        {
            Class1 obj= new Class1();
           
            Console.WriteLine("Student Name : " + obj.name);
            Console.WriteLine("Student Address : " + obj.address);
            Console.WriteLine("Student Phone Number : " + obj.phoneno);
            Console.WriteLine("Student Age : " + obj.age);
            Console.WriteLine("Student Mark1 : " + obj.mark1);
            Console.WriteLine("Student Mark2 : " + obj.mark2);
            Console.WriteLine("Student Mark3 : " + obj.mark3);

        }
        public static void Average()
        { 
            Class1 obj1= new Class1();
            obj1.avg = (obj1.mark1 + obj1.mark2 + obj1.mark3) / 3;
            Console.WriteLine("Average of the marks= "+obj1.avg);

        }
    }
}
