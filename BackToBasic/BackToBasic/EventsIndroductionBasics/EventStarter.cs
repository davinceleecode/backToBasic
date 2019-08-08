using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.EventsIndroductionBasics
{
    class EventStarter
    {
      public static void Main()
        {
            Ticker ticker = new Ticker(2000);

            AListener aListener = new AListener();
            //aListener.Listen(ticker);

            ticker.Begin();
        }
    }
}
