using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    class CritGloves : Passive
    {
        public float critChance = 30.0f;
        public CritGloves(){
            type = ItemType.CritGloves;
            name = "Luvas de Critico🥊🩸";
            id = "CritGloves";
        }
        public void equipItem(PC player){
            player.critChance += critChance;
            Console.WriteLine("Luvas de Bonus Critico Equipado");
        }


    }
}