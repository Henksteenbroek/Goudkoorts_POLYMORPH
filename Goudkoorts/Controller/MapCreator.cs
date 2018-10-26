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
        }

        public Field[,] CreateArray()
        {
            return new Field[,]
            {
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

                            break;
                        case Direction.DOWN:
                            break;
                        case Direction.LEFT:
                            break;
                        case Direction.RIGHT:
                            break;
                        case Direction.SPLIT:
                            break;
                    }
                    //MapArray[x, y] =
                }
            }
        }

    }
}