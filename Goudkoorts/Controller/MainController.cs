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
        private Thread CountDownThread;
        private int CountdownSeconds = 2;

        public MainController()
        {
            game = new Game();
            new MapCreator(game);
            new InputView();
            new OutputView(game);
            CountDownThread = new Thread(CountDown);
            CountDownThread.Start();
        }

        private void CountDown()
        {
            int i = CountdownSeconds;
            while (true)
            {
                Console.WriteLine(i);
                i--;
                Thread.Sleep(1000);
                if(i == 0)
                {
                    i = CountdownSeconds;
                    game.PlayGameTick();
                }
            }
        }
    }
}
