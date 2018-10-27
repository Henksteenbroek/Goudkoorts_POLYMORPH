using Goudkoorts.Model;
using Goudkoorts.Model.Fields;

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
            return new Field[,]
            {
                {new Water(Direction.LEFT)      , new Water(Direction.LEFT) , new Water(Direction.LEFT) , new Water(Direction.LEFT) , new Water(Direction.LEFT) , new Water(Direction.LEFT) , new Water(Direction.LEFT) , new Water(Direction.LEFT) , new Water(Direction.LEFT) , new Water(Direction.LEFT) , new Water(Direction.LEFT) , new Water(Direction.LEFT)},
                {new Field(Direction.LEFT)      , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Dock(Direction.LEFT)  , new Field(Direction.LEFT) , new Field(Direction.LEFT)},
                {null                           , null                      , null                      , null                      , null                      , null                      , null                      , null                      , null                      , null                      , null                      , new Field(Direction.UP)},
                {new Warehouse(Direction.RIGHT) , new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.DOWN) , null                      , new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.DOWN) , null                      , new Field(Direction.UP) },
                {null                           , null                      , null                      , new Merge(Direction.RIGHT), new Field(Direction.RIGHT), new Split(Direction.SPLIT), null                      , null                      , null                      , new Merge(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.UP) },
                {new Warehouse(Direction.RIGHT) , new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.UP)   , null                      , new Field(Direction.RIGHT), new Field(Direction.DOWN) , null                      , new Field(Direction.RIGHT), new Field(Direction.UP)   , null                      , null },
                {null                           , null                      , null                      , null                      , null                      , null                      , new Merge(Direction.RIGHT), new Field(Direction.RIGHT), new Split(Direction.SPLIT), null                      , null                      , null },
                {new Warehouse(Direction.RIGHT) , new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.UP)   , null                      , new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.DOWN) },
                {null                           , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) }
            };
        }

        public void CreateLinks()
        {
            for (int x = 0; x < MapArray.GetLength(0); x++)
            {
                for (int y = 0; x < MapArray.GetLength(1); y++)
                {
                    switch (MapArray[x, y].Direction)
                    {
                        case Direction.UP:
                            MapArray[x, y].Next = MapArray[x, y - 1];
                            break;
                        case Direction.DOWN:
                            MapArray[x, y].Next = MapArray[x, y + 1];
                            break;
                        case Direction.LEFT:
                            MapArray[x, y].Next = MapArray[x-1, y];
                            break;
                        case Direction.RIGHT:
                            MapArray[x, y].Next = MapArray[x + 1, y];
                            break;
                        case Direction.SPLIT:
                            MapArray[x, y].NextUp = MapArray[x - 1, y];
                            MapArray[x, y].NextDown = MapArray[x - 1, y];
                            MapArray[x, y].Next = MapArray[x, y].NextUp;
                            break;
                    }
                    
                }
            }
        }

    }
}