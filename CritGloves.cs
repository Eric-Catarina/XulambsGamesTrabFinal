using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    class CritGloves : Passive
    {
        public float critChance = 80.0f;
        public void equipItem(PC player){
            player.critChance += critChance;
        }


    }
}