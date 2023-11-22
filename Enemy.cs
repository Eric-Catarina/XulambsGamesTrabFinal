using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    internal class Enemy
    {
        public Enemy(){
        }
        protected int hp = 30;

        public int Hp { get { return hp; } 
            set { hp = value; } 
        }

        //implementar parametros e returns quando implementados
        
        public int TakeDamage(int value)
        {
            hp -= value;
            return value;
        }

        public int GetHp()
        {
            Console.WriteLine("Vida do goblin: " + hp);
            return hp;
        }

        public bool Died()
        {
            return hp > 0;
        }

    }
}