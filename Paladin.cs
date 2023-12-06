using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud{
    internal class Paladin: PC{
        public Paladin(){
            maxHp = 250;
            hp = maxHp;
            strenght = 10;
            charType = CharacterType.Paladino;
            StrenghtPotion strenghtPotion = new StrenghtPotion();
            StrenghtGloves strenghtGloves = new StrenghtGloves();
            HealthPotion healthPotion = new HealthPotion();

            inventory.Add(strenghtGloves);
            inventory.Add(strenghtPotion);
            inventory.Add(healthPotion);
            
        }
  
    }
}