using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model.Fields
{
    public class Split : Field
    {
        public int State { get; set; }

        public Split(Direction direction) : base(direction)
        { 
            Next = NextUp;
            DrawChar = '╝';
            State = 0;
        }

        private void setState()
        {
            if(State == 1)
            {
                Next = NextUp;
                DrawChar = '╝';
                State = 0;
            } else
            {
                Next = NextDown;
                DrawChar = '╗';
                State = 1;
            }
        }
    }
}
