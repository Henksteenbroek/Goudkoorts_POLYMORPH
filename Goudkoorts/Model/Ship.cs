using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model
{ 
    public class Ship
    {
        int Capacity = 8;
        int Cargo { get; set; }
        bool IsDocked { get; set; }
        public char DrawChar { get; set; }
       
        public Ship() 
        {
            DrawChar = 'S';
        }

        bool IsFull
        {
            get
            {
                if (Cargo >= Capacity)
                    return true;
                return false;
            }
        }

    }
}
