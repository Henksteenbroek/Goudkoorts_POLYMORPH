using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model.Fields
{
    public class Merge : Field
    {
        public int State { get; set; }

        public Merge(Direction direction) : base(direction)
        {
            DrawChar = '╩';
            State = 0;
        }

        private void setState()
        {
            if (State == 1)
            {
                DrawChar = '╩';
                State = 0;
            }
            else
            {
                DrawChar = '╦';
                State = 1;
            }
        }
    }
}
