using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            string LastName = "Wademan";
            string FirstName = "David";
            int Age = 40;

            Person person1 = new Person(FirstName, LastName);
            Console.WriteLine(person1.GetFullname());

            // Constructor Overloading
            Person person2 = new Person(FirstName, Age);
            Console.WriteLine(person2.GetFullname());

            // Constructor Overloading
            Person person3 = new Person(FirstName, LastName, Age);
            Console.WriteLine(person3.GetFullname());

            // Constructor Overloading
            Person person4 = new Person();
            Console.WriteLine(person4.GetFullname());

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
