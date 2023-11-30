using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud{
    internal class Sword : Weapon{
        WeaponType type;
        public Sword(){
            type = WeaponType.Sword;
            strenght = 10;
        }
        public int weight = 5000;

    }
}
