using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic
{
    class MyCustomEvents2
    {
        static void Main(string[] args)
        {
            var tower = new ClockTower();
            var john = new PersonChime("John", tower);


            tower.ChimeFivePM();
        }
    }

    public class PersonChime
    {
        private string _name;
        private ClockTower _tower;

        public PersonChime(string name, ClockTower tower)
        {
            _name = name;
            _tower = tower;


            _tower.Chime += (object sender, ClockTowerEventArgs args) =>
            {

                Console.WriteLine("{0} heard the clock chime.", _name);
                switch (args.Time)
                {
                    case 6: Console.WriteLine("{0} is waking up", _name);
                        break;
                    case 17: Console.WriteLine("{0} is going home", _name);
                        break;
                }
            };
        }


    }


    public class ClockTowerEventArgs : EventArgs
    {
        public int Time { get; set; }
    }



    public delegate void ChimeEventHandler(object sender, ClockTowerEventArgs args);
    public class ClockTower
    {
        public event ChimeEventHandler Chime;
        public void ChimeFivePM()
        {
            Chime(this, new ClockTowerEventArgs { Time = 17 });
        }

        public void ChimeSixAM()
        {
            Chime(this, new ClockTowerEventArgs { Time = 6 });
        }
    }
}
