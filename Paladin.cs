using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud{
    internal class Paladin: PC{
        public Paladin(){
            charType = CharacterType.Paladino;
        }
        public void attack(Enemy other){
            if (other.GetHp() <= 0){
                return;
            }
            var random = new Random();
            if (random.Next(1,100) < critChance){
                other.TakeDamage(strenght * 2);
                Console.WriteLine("Paladin just hit for a whooping "  + strenght * 2 + " damage!!!");
            }
            else{
                other.TakeDamage(strenght);
            }
        }


    }
}