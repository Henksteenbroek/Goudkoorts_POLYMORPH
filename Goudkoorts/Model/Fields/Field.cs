using Goudkoorts.Model.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model.Fields
{
    public class Field
    {
        public Field Next { get; set; }
        public Field NextUp { get; set; }
        public Field NextDown { get; set; }
        public Field Previous { get; set; }
        public Field PreviousUp { get; set; }
        public Field PreviousDown { get; set; }
        public GameObject Obj { get; set; }
        public Direction Direction { get; set; }
        private char drawChar;
        public char DrawChar
        {
            get
            {
                if (Obj == null)
                    return drawChar;

                return Obj.DrawChar;
            }
            set { drawChar = value; }
        }

        public Field(Direction direction)
        {
            Direction = direction;
            DrawChar = '═';
        }

       
        public void placeObj(GameObject obj)
        {
            Obj = obj;
        }

        public void removeObj()
        {
            Obj = null;
        }


    }
}
