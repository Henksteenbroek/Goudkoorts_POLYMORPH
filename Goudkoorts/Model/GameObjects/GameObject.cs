using Goudkoorts.Model.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model.GameObjects
{
    public class GameObject
    {
        public char DrawChar { get; set; }
        public Field Location { get; set; }
        public int Cargo { get; set; }

        public GameObject()
        {

        }

        public void move()
        {
            if (Location.Next == null)
            {
                Location.removeObj();
            }
            else if (Location.Next.Obj == null)
            {
                Location.Next.placeObj(this);
                Location.removeObj();
                Location = Location.Next;
            }
        }

        public virtual void unloadCargo()
        {

        }
    }
}
