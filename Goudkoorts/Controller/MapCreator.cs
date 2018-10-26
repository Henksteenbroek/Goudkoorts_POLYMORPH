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
                {null                           , null                      , null                      , new Merge(Direction.RIGHT), new Field(Direction.RIGHT), new Split()               , null                      , null                      , null                      , new Merge(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.UP) },
                {new Warehouse(Direction.RIGHT) , new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.UP)   , null                      , new Field(Direction.RIGHT), new Field(Direction.DOWN) , null                      , new Field(Direction.RIGHT), new Field(Direction.UP)   , null                      , null },
                {null                           , null                      , null                      , null                      , null                      , null                      , new Merge(Direction.RIGHT), new Field(Direction.RIGHT), new Split()               , null                      , null                      , null },
                {new Warehouse(Direction.RIGHT) , new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.UP)   , null                      , new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.RIGHT), new Field(Direction.DOWN) },
                {null                           , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Yard(Direction.LEFT)  , new Field(Direction.LEFT) , new Field(Direction.LEFT) , new Field(Direction.LEFT) }
            };
        }

        public void CreateLinks()
        {
            //for (int col = 0; col < MapArray.GetLength(0); col++)
            //{
            //    for (int i = row; row < arr.GetLength(1); row++)
            //    {
            //        arr[col, row] =  /*something*/;
            //    }
            //}
        }

    }
}