using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud{
    internal abstract class Weapon : IUsable{
        public enum WeaponType{
            Sword,
            Bow,
            Dagger
        }

        public WeaponType type;
        public int weight;
        public int strenght;

        public void use(PC player)
        {
            if (canBeUsedUsed(player)){
                player.weapon = this;
            }
        }

        public bool canBeUsedUsed(PC who)
        {
            if (who.charType == PC.CharacterType.Elfo && type == WeaponType.Dagger){
                Console.WriteLine("Elfos não podem usar adagas");
                return false;
            }
            return true;
        }
    }
}