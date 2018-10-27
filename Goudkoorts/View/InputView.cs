using Goudkoorts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.View
{
    public class InputView
    {
        ConsoleKeyInfo key;
        int returnValue;

        public InputView()
        {

        }

        public ConsoleKeyInfo validInputGiven()
        {
            bool validInputGiven = false;

            Console.WriteLine("> gebruik pijltjestoetsen (s = stop, r = reset)");
            while (!validInputGiven)
            {
                key = Console.ReadKey();
                if (key.Key != ConsoleKey.D1 && key.Key != ConsoleKey.D2 && key.Key != ConsoleKey.D3 && key.Key != ConsoleKey.D4 && key.Key != ConsoleKey.D5)
                {
                    Console.WriteLine(" is geen geldig teken, gebruik de pijltestoetsen of 's' of 'r'");
                }
                else
                {
                    validInputGiven = true;
                }
            }
            return key;
        }

        public int readInput(ConsoleKeyInfo key)
        {
            this.key = key;
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    returnValue = (int)Direction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    returnValue = (int)Direction.DOWN;
                    break;
                case ConsoleKey.LeftArrow:
                    returnValue = (int)Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    returnValue = (int)Direction.RIGHT;
                    break;
                case ConsoleKey.R:
                    returnValue = -1;
                    break;
                case ConsoleKey.S:
                    returnValue = -2;
                    break;
            }
            return returnValue;
        }
    }
}
