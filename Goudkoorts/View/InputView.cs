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

        public InputView(Game game)
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
                case ConsoleKey.D1:
                    Console.Write("you pressed 1");
                    returnValue = 1;
                    break;
                case ConsoleKey.D2:
                    returnValue = 2;
                    break;
                case ConsoleKey.D3:
                    returnValue = 3;
                    break;
                case ConsoleKey.D4:
                    returnValue = 4;
                    break;
                case ConsoleKey.D5:
                    returnValue = 5;
                    break;
            }
            return returnValue;
        }
    }
}
