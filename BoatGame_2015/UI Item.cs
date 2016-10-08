using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BoatGame_2015
{
    class UI_Item
    {
        private Rectangle rectangle;
        private bool pressed;
        private Texture2D texture;

        public bool Pressed { get { return pressed; } set { pressed = value; } }
        public Rectangle Rectangle { get { return rectangle; } }

        public Texture2D Texture { get { return texture; } }

        public UI_Item(Rectangle rect, Texture2D texture)
        {
            rectangle = rect;
            pressed = false;
            this.texture = texture;
        }

        public virtual void Draw(SpriteBatch spriteBatch, SpriteFont font, GraphicsDevice device, Color color)
        {

        }
    }
}
