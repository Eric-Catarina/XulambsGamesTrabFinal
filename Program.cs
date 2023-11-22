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
            Enemy goblin = new Enemy();
            Paladin paladino = new Paladin();
            Sword espada = new Sword();
            paladino.equipWeapon(espada);
            goblin.GetHp();
            paladino.attack(goblin);
            goblin.GetHp();

        }
    }
}