using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToBasic.DependencyInjection.PoorsManDI
{
    public  class Sword : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Attack Using Sword!!!");
        }
    }
}
