﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.DataAccess.Entities
{
    public class Player : EntityBase
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual Team Team { get; set; }
    }
}
