using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatGame_2015
{
    public sealed class Death
    {
        //fields
        public Doom die;
        public static readonly Death instance = new Death();

        //constructor
        private Death()
        {
            die = Doom.alive;

        }
    }
}
