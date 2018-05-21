using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Player
    {
        private int _lives = 100;
        
        public int Lives {
            get
            {
                return _lives;
            }
            set
            {
                if (value <= 0 || value >= 1000)
                {
                    Console.WriteLine("This does not make any sense.");
                    return;
                }
            }
        }
    }
}
