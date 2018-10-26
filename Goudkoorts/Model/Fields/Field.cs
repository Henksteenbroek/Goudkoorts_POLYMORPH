using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model.Fields
{
    public class Field
    {
        public Field Next { get; set; }
        public Field NextUp { get; set; }
        public Field NextDown { get; set; }
        public Cart Cart { get; set; }
        public Direction Direction { get; set; }
        private char drawChar;

        public Field()
        {
        }

        public Field(Direction direction)
        {
            Direction = direction;
            DrawChar = '═';
        }

        public virtual char DrawChar
        {
            get
            {
                if (Cart == null)
                    return drawChar;

                return Cart.DrawChar;
            }
            set { this.drawChar = value; }
        }

        public void placeCart(Cart cart)
        {
            Cart = cart;
        }

        public void removeCart()
        {
            Cart = null;
        }


    }
}
