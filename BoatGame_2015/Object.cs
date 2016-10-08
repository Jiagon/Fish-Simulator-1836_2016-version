using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace BoatGame_2015
{
    class Object
    {
        //fields
        protected Rectangle rekt;
        protected ObjectType type;

        public Rectangle Rekt
        {
            get { return this.rekt; }
            set { this.rekt = value; }
        }

        public virtual ObjectType Type
        {
            get { return this.type; }
        }

        //constructors
        public Object(Rectangle rect)
        {
            rekt = rect;
        }
    }
}
