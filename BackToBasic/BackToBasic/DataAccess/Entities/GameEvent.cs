using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.DataAccess.Entities
{
    public class GameEvent:EntityBase
    {
        public virtual Game Game { get; set; }
        public virtual Player Player { get; set; }
        public int PointValue { get; set; }
         
    }
}
