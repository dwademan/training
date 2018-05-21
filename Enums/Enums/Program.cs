using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Enums.Player();
            player.Weapon = Weapons.SniperRifle;

            if (player.Weapon == Weapons.MachineGun)
            {
                Console.WriteLine("Run");
                
            }
            else if (player.Weapon == Weapons.Kalashnikov)
            {
                Console.WriteLine("Give up!");
            }
            else if (player.Weapon == Weapons.SniperRifle)
            {
                Console.WriteLine("Hide");
            }
            else if (player.Weapon == Weapons.FlameThrower)
            {
                Console.WriteLine("You are toast!");
            }
            else
            {
                Console.WriteLine("You have no weapon!");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
