using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model.Fields
{
    public class Water : Field
    {
        public Ship Ship { get; set; }

        public Water()
        {
            DrawChar = '~';
        }
        public override char DrawChar
        {
            get
            {
                if (Ship == null)
                    return DrawChar;

                return Ship.DrawChar;
            }
            set { DrawChar = value; }
        }

    }
}
