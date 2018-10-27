using Goudkoorts.Model.Fields;
using Goudkoorts.Model.GameObjects;
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
        public Water ShipSpawner { get; set; }
        public List<GameObject> GameObjects{ get; set; }
        Random random;
        
        public Game()
        {
            GameObjects = new List<GameObject>();
            random = new Random();
        }

        public void playGameTick()
        {
            Dock.unloadCart();
            
            foreach(var item in GameObjects)
            {
                item.move();
            }
            if(random.Next(1, 5) == 1)
            {
                generateCart();
            }
            if (random.Next(1, 20) == 1)
            {
                GameObjects.Add(ShipSpawner.generateShip());
            }
        }

        public void generateCart()
        {
            switch (random.Next(1, 4))
            {
                case 1:
                    GameObjects.Add(WarehouseA.generateCart());
                    break;
                case 2:
                    GameObjects.Add(WarehouseB.generateCart());
                    break;
                case 3:
                    GameObjects.Add(WarehouseC.generateCart());
                    break;
            }
        }

    }
}
