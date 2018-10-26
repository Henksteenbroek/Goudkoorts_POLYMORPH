using Goudkoorts.Model;
using Goudkoorts.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Controller
{
    public class MainController
    {
        private Game game;
        public MainController()
        {
            game = new Game();
            new MapCreator(game);
            new InputView();
            new OutputView(game);
        }
    }
}
