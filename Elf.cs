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

 
            public override void attack(Enemy other)
        {

            if (other == null)
            {
                enemy = new Enemy(this);
                other = enemy;
            }
            if (other.GetHp() <= 0)
            {
                enemy = new Enemy(this);
                other = enemy;
            }
            var random = new Random();
            //caso o ataque seja um critico, o dano eh dobrado
            if (random.Next(1, 100) < critChance)
            {
                Console.WriteLine("Você causou " + strenght * 2 + " de dano com um acerto crítico!!!" );
                other.TakeDamage(strenght * 2);
            }
//caso o ataque nao seja critico, o elfo tem uma chance de realizar um golpe rapido que causa um dano fixo adicional
            else if(random.Next(1, 6) < agilityBonus){
                Console.WriteLine("Você conseguiu abusar de sua grande agilidade para desferir um golpe bem encaixado, causando 3 pontos de dano extra, com um total de " + (strenght + 3));
                other.TakeDamage(strenght + 3);
            }
            //caso tambem nao aconteca um golpe rapido, apenas um ataque normal eh desferido
            else
            {
                Console.WriteLine("Você causou " + strenght + " de dano");
                other.TakeDamage(strenght);
            }
        }
    }
}