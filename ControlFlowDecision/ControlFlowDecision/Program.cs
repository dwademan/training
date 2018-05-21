using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Player type: ");
            string player = Console.ReadLine();
            player = player.ToUpper();

            if (player.Equals("AI"))
            {
                Console.WriteLine("The player is AI.");
            }
            else if (player.Equals("HUMAN")) {
                Console.WriteLine("The player is human.");
            } else {
                Console.WriteLine("The player is not AI or Human.");
            }

            if (player.Equals("ROBOT"))
            {
                Console.WriteLine("The player is a robot.");
            }

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}
