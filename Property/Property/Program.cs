using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Lives = 1001;

            Console.WriteLine(player.Lives);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
