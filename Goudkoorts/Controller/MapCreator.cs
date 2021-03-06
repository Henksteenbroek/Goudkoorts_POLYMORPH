﻿using Goudkoorts.Model;
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

            Dock Dock = new Dock(Direction.LEFT);
            game.Dock = Dock;

            Water ShipSpawner = new Water(Direction.RIGHT);
            game.ShipSpawner = ShipSpawner;

            Split SplitA = new Split(Direction.SPLIT);
            game.SplitA = SplitA;

            Split SplitB = new Split(Direction.SPLIT);
            game.SplitB = SplitB;


            temp = new Field[,]
            {
                {ShipSpawner                    , new Water(Direction.RIGHT) , new Water(Direction.RIGHT) , new Water(Direction.RIGHT) , new Water(Direction.RIGHT) , new Water(Direction.RIGHT) , new Water(Direction.RIGHT) , new Water(Direction.LEFT) , new Water(Direction.RIGHT) , new Water(Direction.RIGHT) , new Water(Direction.RIGHT) , new Water(Direction.RIGHT) },
                {new Field(Direction.LEFT)      , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) , Dock                      , new Field(Direction.LEFT) , new Field(Direction.LEFT) },
                {null                           , null                      , null                      , null                      , null                      , null                      , null                      , null                      , null                      , null                      , null                      , new Field(Direction.UP)   },
                {WarehouseA                     , new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.DOWN) , null                      , new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.DOWN) , null                      , new Field(Direction.UP)   },
                {null                           , null                      , null                      , new Merge(Direction.RIGHT), new Field(Direction.RIGHT), SplitA                    , null                      , null                      , null                      , new Merge(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.UP)   },
                {WarehouseB                     , new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.UP)   , null                      , new Field(Direction.RIGHT), new Field(Direction.DOWN) , null                      , new Field(Direction.RIGHT), new Field(Direction.UP)   , null                      , null                      },
                {null                           , null                      , null                      , null                      , null                      , null                      , new Merge(Direction.RIGHT), new Field(Direction.RIGHT), SplitB                    , null                      , null                      , null                      },
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
                                if (x != 0)
                                {
                                    temp[x, y].Next = temp[x-1, y];
                                    //temp[x - 1, y].Previous = temp[x, y];
                                    //om doubly te maken, kan evt ook geschreven worden als temp[x,y].Previous.Next = temp[x,y];
                                }
                                break;
                            case Direction.DOWN:
                                if (x + 1 < temp.GetLength(0))
                                {
                                    temp[x, y].Next = temp[x+1, y];
                                    //temp[x + 1, y].Previous = temp[x, y];
                                }
                                break;
                            case Direction.LEFT:
                                if (y != 0)
                                {
                                    temp[x, y].Next = temp[x, y-1];
                                    //temp[x, y - 1].Previous = temp[x, y];
                                    //je krijgt hier object errors maar idk waarom?
                                }
                                break;
                            case Direction.RIGHT:
                                if (y + 1 < temp.GetLength(1))
                                {
                                    temp[x, y].Next = temp[x, y+1];
                                    //temp[x, y + 1].Previous = temp[x, y];
                                }
                                break;
                            case Direction.SPLIT:
                                temp[x, y].NextUp = temp[x-1, y];
                                temp[x, y].NextDown = temp[x+1, y];
                                temp[x, y].Next = temp[x, y].NextUp;
                                
                                temp[x,y].Previous = temp[x, y - 1]; // de Previous van een Split is altijd LEFT
                                break;
                        }
                    }

                }
            }

        }

    }
}