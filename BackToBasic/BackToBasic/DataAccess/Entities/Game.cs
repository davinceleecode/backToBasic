using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.DataAccess.Entities
{
    public class Game : EntityBase
    {
        public virtual Team HomeTeam { get; set; }
        public virtual Team AwayTeam { get; set; }

        public DateTime StartTime { get; set; }

    }
}
