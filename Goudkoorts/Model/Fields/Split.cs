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
        public Field NextUp;
        public Field NextDown;
        public Split(Direction direction) : base(direction)
        {
            State = 0;
            setState();
        }

        private void setState()
        {
            if(State == 0)
            {
                Next = NextUp;
                State = 1;
            } else
            {
                Next = NextDown;
                State = 0;
            }
        }
    }
}
