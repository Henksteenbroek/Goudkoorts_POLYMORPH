using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model.Fields
{
    public class Warehouse : Field
    {

        public Warehouse(Direction direction) : base(direction)
        {
            DrawChar = 'W';
        }

        public Cart generateCart()
        {
            Cart cart = new Cart();
            cart.Location = Next;
            Next.placeObj(new Cart());
            return cart;
        }
    }
}
