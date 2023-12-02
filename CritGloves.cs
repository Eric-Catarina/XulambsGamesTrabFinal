using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    class CritGloves : Passive
    {
        public float critChance = 80.0f;
        public CritGloves(){
            name = "Luvas de Critico";
            id = "CritGloves";
        }
        public void equipItem(PC player){
            player.critChance += critChance;
            Console.WriteLine("Luvas de Bonus Critico Equipado");
        }


    }
}