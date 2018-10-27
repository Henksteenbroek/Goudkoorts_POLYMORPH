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
        public Dock Dock { get; set; }
        public List<Cart> Carts { get; set; }
        Random random;
        
        public Game()
        {
            Carts = new List<Cart>();
            random = new Random();
        }

        public void playGameTick()
        {
            Dock.unloadCart();

            foreach(var item in Carts)
            {
                item.move();
            }
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
                    Carts.Add(WarehouseA.generateCart());
                    break;
                case 2:
                    Carts.Add(WarehouseB.generateCart());
                    break;
                case 3:
                    Carts.Add(WarehouseC.generateCart());
                    break;
            }
        }
    }
}
