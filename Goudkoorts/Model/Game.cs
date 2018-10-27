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
        public Field[,] MapArray { get; set; }
        public Warehouse WarehouseA { get; set; }
        public Warehouse WarehouseB { get; set; }
        public Warehouse WarehouseC { get; set; }
        public Cart Cart { get; set; }
        Random random;
        
        public Game()
        {
            random = new Random();
            Cart = new Cart();
        }

        public void playGameTick()
        {
            Cart.move();
            if(random.Next(1, 5) == 1)
            {
                generateCart();
            }
        }

        public void generateCart()
        {
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
