using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud{
    internal class Orc: Enemy
    {
        private IObservador player;
        public Orc(PC jogador) : base(jogador)
        {
            maxHp = 150;
            hp = maxHp;
            dano = 20;
        }
        public void ShowHp(){
            Console.WriteLine("O orc agora está com " + hp + "/" + maxHp + " de vida❤️.");
        }
    }
}