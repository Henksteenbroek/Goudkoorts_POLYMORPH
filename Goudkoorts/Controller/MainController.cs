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
        public MainController()
        {
            Game game = new Game();
            new MapCreator(game);
            new InputView();
            new OutputView();
        }
    }
}
