using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine("--------------------");
            Console.WriteLine("Counting from 0 to 9");
            Console.WriteLine("--------------------");
            Console.WriteLine(" ");

            for (int i = 0; i < 10; i++)
            {

                if (i == 7)
                {
                    Console.WriteLine("***** I is {0}. Break ....", i);
                    break;
                }

                if (i == 3)
                {
                    Console.WriteLine("***** I is {0}. Continue ....", i);
                    continue;
                }

                Console.WriteLine("The I number is {0}", i);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
