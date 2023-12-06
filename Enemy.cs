using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    abstract class Enemy : IInimigoObservado
    {
        public Enemy(PC jogador){
            RegistrarObservador(jogador);
        }
        private IObservador player;
        protected int hp = 130, maxHp = 130;
        public int dano = 10;
        private int agilityBonus = 0;
        private int agilityGoal = 4;

        public int Hp { get { return hp; } 
            set { hp = value; } 
        }
        public int Attack(PC player)
        {
            dano = 10;
            player.hp -= dano;
            return dano;
        }
        
        public int TakeDamage(int value)
        {
            hp -= value;
            if (hp <= 0){
                Died();
            }
            else{
                ShowHp();
            }
            return value;
        }

        public int GetHp()
        {
            return hp;
        }

        public virtual void ShowHp(){
            Console.WriteLine("O inimigo agora está com " + hp + "/" + maxHp + " de vida❤️.");

        }

        public bool Died()
        {
            Console.WriteLine("O inimigo atual morreu💀, indo para o próximo inimigo");
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