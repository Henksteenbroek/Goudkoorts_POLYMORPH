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
        public Field()
        {
            Next = new Warehouse();
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
