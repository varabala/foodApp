﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commun
{
    public class Player
    {
        public int HP { get; set; }
        public override string ToString()
        {
            return $"Player(HP={HP})";
            //string interpolation!!!
        }
    }
}
