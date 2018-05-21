using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingDoWhile2
{
    class Program
    {
        static void Main(string[] args)
        {

            // -----
            Console.WriteLine("Enter in you while input: ");
            string input1 = Console.ReadLine();
            while (!input1.Equals(string.Empty))
            {
                Console.WriteLine("Enter in you while input: ");
                Console.WriteLine("Your while input is {0}", input1);
                input1 = Console.ReadLine();
            }

            // -----
            string input2 = string.Empty;
            do
            {
                Console.WriteLine("Enter in you do/while input: ");
                input2 = Console.ReadLine();
                Console.WriteLine("Your do/while input is {0}", input2);

            } while (!input2.Equals(string.Empty));

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
