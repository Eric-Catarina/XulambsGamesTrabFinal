using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paladin paladino = new Paladin();
            Enemy goblin = new Enemy(paladino);
            StrenghtPotion strenghtPotion = new StrenghtPotion();


            Sword espada = new Sword();
            Bow arcoDoSukuna = new Bow();
            espada.use(paladino);
            arcoDoSukuna.use(paladino);

            strenghtPotion.use(paladino);

            CritGloves luvasDeCritico = new CritGloves();
            luvasDeCritico.equipItem(paladino);
            StrenghtGloves luvasDeDano = new StrenghtGloves();
            luvasDeDano.equipItem(paladino);

            goblin.ShowHp();  
            paladino.attack(goblin);
            goblin.ShowHp();  
            paladino.attack(goblin);
            goblin.ShowHp();  
            if (goblin.GetHp() >= 0){
                paladino.attack(goblin);
                goblin.ShowHp();  
            }

        }
    }
}