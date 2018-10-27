using Goudkoorts.Model;
using Goudkoorts.Model.Fields;
using System;

namespace Goudkoorts.Controller
{
    public class MapCreator
    {
        public Game game;
        public Field[,] MapArray;

        public MapCreator(Game game)
        {
            this.game = game;
            MapArray = CreateArray();
            game.MapArray = MapArray;
        }

        public Field[,] CreateArray()
        {
            Field[,] temp;

            Warehouse WarehouseA = new Warehouse(Direction.RIGHT);
            game.WarehouseA = WarehouseA;
            Warehouse WarehouseB = new Warehouse(Direction.RIGHT);
            game.WarehouseB = WarehouseB;
            Warehouse WarehouseC = new Warehouse(Direction.RIGHT);
            game.WarehouseC = WarehouseC;

            temp = new Field[,]
            {
                {new Water(Direction.LEFT)      , new Water(Direction.LEFT) , new Water(Direction.LEFT) , new Water(Direction.LEFT) , new Water(Direction.LEFT) , new Water(Direction.LEFT) , new Water(Direction.LEFT) , new Water(Direction.LEFT) , new Water(Direction.LEFT) , new Water(Direction.LEFT) , new Water(Direction.LEFT) , new Water(Direction.LEFT)},
                {new Field(Direction.LEFT)      , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Dock(Direction.LEFT)  , new Field(Direction.LEFT) , new Field(Direction.LEFT)},
                {null                           , null                      , null                      , null                      , null                      , null                      , null                      , null                      , null                      , null                      , null                      , new Field(Direction.UP)},
                {WarehouseA                     , new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.DOWN) , null                      , new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.DOWN) , null                      , new Field(Direction.UP) },
                {null                           , null                      , null                      , new Merge(Direction.RIGHT), new Field(Direction.RIGHT), new Split(Direction.SPLIT), null                      , null                      , null                      , new Merge(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.UP) },
                {WarehouseB                     , new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.UP)   , null                      , new Field(Direction.RIGHT), new Field(Direction.DOWN) , null                      , new Field(Direction.RIGHT), new Field(Direction.UP)   , null                      , null },
                {null                           , null                      , null                      , null                      , null                      , null                      , new Merge(Direction.RIGHT), new Field(Direction.RIGHT), new Split(Direction.SPLIT), null                      , null                      , null },
                {WarehouseC                     , new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.UP)   , null                      , new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.DOWN) },
                {null                           , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) }
            };

            CreateLinks(temp);
            return temp;
        }

        public void CreateLinks(Field[,] temp)
        {
            for (int x = 0; x < temp.GetLength(0); x++)
            {
                for (int y = 0; y < temp.GetLength(1); y++)
                {
                    if (temp[x, y] != null)
                    {
                        switch (temp[x, y].Direction)
                        {
                            case Direction.UP:
                                if (y != 0)
                                {
                                    temp[x, y].Next = temp[x, y - 1];
                                }
                                break;
                            case Direction.DOWN:
                                if (y + 1 < temp.GetLength(1))
                                {
                                    temp[x, y].Next = temp[x, y + 1];
                                }
                                break;
                            case Direction.LEFT:
                                if (x != 0)
                                {
                                    temp[x, y].Next = temp[x - 1, y];
                                }
                                break;
                            case Direction.RIGHT:
                                if (x + 1 < temp.GetLength(0))
                                {
                                    temp[x, y].Next = temp[x + 1, y];
                                }
                                break;
                            case Direction.SPLIT:
                                temp[x, y].NextUp = temp[x - 1, y];
                                temp[x, y].NextDown = temp[x - 1, y];
                                temp[x, y].Next = temp[x, y].NextUp;
                                break;
                        }
                    }

                }
            }
        }

    }
}