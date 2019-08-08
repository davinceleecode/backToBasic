using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.DependencyInjection.PoorsManDI
{
    public class ZeldaLinkToThePast : IGame
    {

        private readonly IWeapon _weapon;


        //public ZeldaLinkToThePast()
        //    : this(new Sword())
        //{
             
        //}

        public ZeldaLinkToThePast(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void PressStart()
        {

            

            Console.WriteLine("Loading Zelda...");
        }

        public void PlayGame()
        {
            _weapon.Attack();
            Console.WriteLine("Killing Gannon!!!!!");
        }
    }
}
