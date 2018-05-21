using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Player
    {
        public Weapons Weapon { get; set; }
    }

    public enum Weapons
    {
        Kalashnikov,
        MachineGun,
        SniperRifle,
        FlameThrower
    }
}
