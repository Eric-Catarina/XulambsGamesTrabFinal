using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud{
    internal abstract class Weapon{
        public enum WeaponType{
            Dagger,
            Sword,
            Bow
        }

        public WeaponType type;
        public int weight;
        public int strenght;

    }
}