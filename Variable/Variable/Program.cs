using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfBooks = 1;
            string myName = "David";
            bool isCompatible = true;
            string xNumber = "2";
            int numberConverted = Convert.ToInt32(xNumber);

            Console.WriteLine(countOfBooks);
            Console.WriteLine(myName);
            Console.WriteLine(isCompatible);
            Console.WriteLine(xNumber);
            Console.WriteLine(numberConverted);

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
