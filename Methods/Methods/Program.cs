using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            string firstName = "David X";
            string lastName = "Wademan";

            var FullName = person.GetFullName(firstName, lastName);

            Console.WriteLine(FullName);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
