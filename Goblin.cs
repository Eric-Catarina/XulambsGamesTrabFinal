using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud{
    internal class Goblin: Enemy{

        private IObservador player;
        private int agilityBonus = 0;
        private int agilityGoal = 4;
        public Goblin(PC jogador) : base(jogador)
        {
            maxHp = 50;
            hp = maxHp;
            dano = 10;
        }
        public int Attack(PC player)
        {
            dano = 10;
            //ativado quando o numero de rodadas ate o ataque muito foda serem percorridas
            if(agilityBonus >= agilityGoal)
            {
                dano = 20;
                Console.WriteLine("Goblin usou Bonus de agilidade, desferindo um ataque veloz que causou o dobro de dano");
                agilityBonus = 0;
                player.hp -= dano;
            }
            else{
            player.hp -= dano;
            Console.WriteLine("Goblin  desferiu um ataque simples, causando " + dano + " pontos de dano");
            agilityBonus++;
            }
            
            return dano;
        }
        public int GetHp()
        {
            return hp;
        }

        public void ShowHp(){
            Console.WriteLine("O goblin agora está com " + hp + "/" + maxHp + " de vida❤️.");
        }
    }
}