using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.DependencyInjection.PoorsManDI
{
    public class SuperNes : IGameConsole
    {
        private readonly IGame _game;



        //public SuperNes()
        //    : this(new ZeldaLinkToThePast())
        //{

        //}
        public SuperNes(IGame game)
        {
            _game = game;
        }


        public void LoadGame()
        {
            _game.PlayGame();
        }

        
    }
}
