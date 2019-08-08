using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.EventsIndroductionBasics
{
    public class AListener
    {
        #region ClassVariable
        #endregion
        
        #region Property
        #endregion

        #region Constructor
        public AListener()
        {

        }
        #endregion

        #region User-Defined Constructor
        #endregion

        #region Built-in Events
        #endregion

        #region User-Defined Methods
        public void Listen(Ticker ticker)
        {
            ticker.Tick += OnTickCallThis;
        }

        private void OnTickCallThis(object sender, EventArgs e)
        {
            Console.WriteLine("Ticker just ticked!");
        }
        #endregion
    }
}
