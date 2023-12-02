using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud{
    internal class Elf: PC{

        public Elf(){
            maxHp = 150;
            hp = maxHp;
            strenght = 5;
            charType = CharacterType.Elfo;
            
        }
        public int agilityBonus;
 

    }
}