using Goudkoorts.Model.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model
{ 
    public class Ship : GameObject
    {
        public int Capacity = 8;
        public bool IsDocked { get; set; }
        public bool IsFull
        {
            get
            {
                if (Cargo >= Capacity)
                    return true;
                return false;
            }
        }
        public Ship() 
        {
            DrawChar = 'S';
        }
       
    }
}
