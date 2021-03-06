﻿using Goudkoorts.Model.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model.Fields
{
    public class Water : Field
    { 

        public Water(Direction direction) : base(direction)
        {
            DrawChar = '~';
        }

        public Ship generateShip()
        {
            Ship ship = new Ship();
            ship.Location = this;
            placeObj(ship);
            return ship;
        }

    }
}
