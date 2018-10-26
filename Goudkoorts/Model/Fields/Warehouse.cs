using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model.Fields
{
    public class Warehouse : Field
    {
        public Warehouse()
        {

        }

        public void generateCart()
        {
            Next.placeCart(new Cart());
        }
    }
}
