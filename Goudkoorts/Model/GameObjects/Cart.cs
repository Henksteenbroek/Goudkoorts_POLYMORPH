using Goudkoorts.Model.Fields;
using Goudkoorts.Model.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model
{
    public class Cart : GameObject
    {
        public Field Location { get; set; }
        public int Cargo = 1;
        public Cart()
        {
            DrawChar = 'O';
        }
    }
}
