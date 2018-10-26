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
        public Cart Cart { get; set; }
        public Direction Direction { get; set; }
        public Field(Direction direction)
        {
            Direction = direction;
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
