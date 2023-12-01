using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud{
    internal class Elf: PC{

        public Elf(){
            strenght = 5;
            charType = CharacterType.Elfo;
        }
        public int agilityBonus;
        public void attack(Enemy other){
            if (other.GetHp() <= 0){
                return;
            }
            var random = new Random();
            if (random.Next(1,100) < critChance){
                other.TakeDamage(strenght * 2);
                Console.WriteLine("Acerto Critico!!"  + strenght * 2);
            }
            else{
                other.TakeDamage(strenght);
            }
        }


    }
}