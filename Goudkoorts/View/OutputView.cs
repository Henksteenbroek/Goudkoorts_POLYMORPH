using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goudkoorts.Model;

namespace Goudkoorts.View
{
    public class OutputView
    {
        private Game game;

        public OutputView(Game game)
        {
            this.game = game;
            PrintMap();
        }

        public void PrintMap()
        {
            for (int x = 0; x < game.MapArray.GetLength(0); x++)
            {
                for (int y = 0; y < game.MapArray.GetLength(1); y++)
                {
                    if (game.MapArray[x, y] == null)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(game.MapArray[x, y].DrawChar);
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
