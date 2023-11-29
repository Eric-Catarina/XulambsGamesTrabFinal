using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    class Enemy : IInimigoObservado
    {
        public Enemy(PC jogador){
            RegistrarObservador(jogador);
        }
        private IObservador player;
        protected int hp = 30;

        public int Hp { get { return hp; } 
            set { hp = value; } 
        }

        //implementar parametros e returns quando implementados
        
        public int TakeDamage(int value)
        {
            hp -= value;
            if (hp <= 0){
                Died();
            }
            return value;
        }

        public int GetHp()
        {
            return hp;
        }

        public void ShowHp(){
            Console.WriteLine("O goblin está com " + hp + " de vida.");
        }

        public bool Died()
        {
            Console.WriteLine("Morreu");
            NotificarPersonagens();
            
            return hp <= 0;
        }

        public void RegistrarObservador(IObservador observador)
        {
            player = observador;
        }

        public void NotificarPersonagens()
        {
            player.Avisar(this);
        }
    }
}