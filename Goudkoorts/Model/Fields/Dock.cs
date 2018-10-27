using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model.Fields
{
    public class Dock : Field
    {
        public Ship DockedShip { get; set; }
        public bool HasShip
        {
            get
            {
                if (DockedShip != null)
                    return true;
                return false;
            }
        }

        public Dock(Direction direction) : base(direction)
        {
            DrawChar = 'D';
        }

        public void unloadCart()
        {
            Obj.unloadCargo();
        }
    }
}
