﻿using Goudkoorts.Model;
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
        private OutputView outputView;
        private Thread CountDownThread;
        private int CountdownSeconds = 1;

        public MainController()
        {
            game = new Game();
            new MapCreator(game);
            new InputView();
            outputView = new OutputView(game);
            CountDownThread = new Thread(CountDown);
            CountDownThread.Start();
            Console.ReadLine();
        }

        private void CountDown()
        {
            int i = CountdownSeconds;
            while (true)
            {
                outputView.PrintMap(i);
                i--;
                Thread.Sleep(500);
                if (i == 0)
                {
                    i = CountdownSeconds;
                    game.playGameTick();
                }
            }
        }
    }
}
