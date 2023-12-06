using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud{
    internal class Elf: PC{

        private int agilityBonus;

        public Elf(){
            maxHp = 150;
            hp = maxHp;
            strenght = 5;
            charType = CharacterType.Elfo;
            agilityBonus = 4;

            CritGloves critGloves = new CritGloves();
            CritPotion critPotion = new CritPotion();
            HealthPotion healthPotion = new HealthPotion();

            inventory.Add(critGloves);
            inventory.Add(critPotion);
            inventory.Add(healthPotion);
            
        }

    }
}