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
            else
            {
                Console.WriteLine("Você causou " + strenght + " de dano");
                other.TakeDamage(strenght);
            }
        }
    }
}