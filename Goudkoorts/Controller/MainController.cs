using Goudkoorts.Model;
using Goudkoorts.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Goudkoorts.Controller
{
    public class MainController
    {
        private Game game;
        private Thread MyNewAwesomeThread;

        public MainController()
        {
            game = new Game();
            new MapCreator(game);
            new InputView();
            new OutputView(game);
            MyNewAwesomeThread = new Thread(test);
            MyNewAwesomeThread.Start();
        }

        private void test()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine(i++);
            }
        }
    }
}
