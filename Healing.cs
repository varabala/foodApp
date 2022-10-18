using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commun
{
    public class Healing : ICharm
    {

        public int Strength { get; set; }
        public void Cast(Player p)
        {
            p.HP += Strength;
        }
    }
}
