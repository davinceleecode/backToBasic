using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.EventsIndroductionBasics
{
   public class Ticker
    {
        #region ClassVariable
        #endregion

        #region Events
        public EventHandler Tick;
        #endregion

        #region Property
        public int Interval { get; protected set; }
        #endregion

        #region Constructors
        public Ticker(int intervalBetweenTicks)
        {
            Interval = intervalBetweenTicks;
        }
        #endregion

        #region User-Defined Constructor
        #endregion

        #region Built-in Events
        #endregion

        #region User-Defined Methods
        public void Begin()
        {
            if(Interval ==0)
            {
                Console.WriteLine("This interval musb be greater than 0.");
                return;
            }

            while (true)
            {
                System.Threading.Thread.Sleep(Interval);
                if(Tick != null)
                {
                    Tick(this, null);
                }
            }
        }
        #endregion
    }
}
