using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do / While statement
            Console.WriteLine("Do/While statement");
            int index1 = 0;
            do
            {
                Console.WriteLine("The number is {0}", index1);
                index1++;
            } while (!index1.Equals(10));

            // While Statement
            Console.WriteLine(" ");
            Console.WriteLine("While statement");
            int index2 = 0;
            while (!index2.Equals(10))
            {
                Console.WriteLine("The number is {0}", index2);
                index2++;
            }

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}
