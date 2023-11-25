using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud{
    internal class Bow : Weapon{
        WeaponType type;
        public Bow(){
            type = WeaponType.Bow;
            strenght = 5;
        }
        public int range = 5;

    }
}