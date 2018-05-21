using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            while (index < 10)
            {
                // prints 0 to 9
                Console.WriteLine("The number id {0}", index);
                index++;
            }

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}
