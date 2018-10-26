using Goudkoorts.Model.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model
{
    public class Game
    {
        Warehouse WarehouseA { get; set; }
        Warehouse WarehouseB { get; set; }
        Warehouse WarehouseC { get; set; }
        
        public Game()
        {

        }

        public void generateCart()
        {
            Random random = new Random();
            switch (random.Next(1, 4))
            {
                case 1:
                    WarehouseA.generateCart();
                    break;
                case 2:
                    WarehouseB.generateCart();
                    break;
                case 3:
                    WarehouseC.generateCart();
                    break;
            }
        }
    }
}
