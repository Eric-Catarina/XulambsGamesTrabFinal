using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    class StrenghtGloves : Passive
    {
        public StrenghtGloves(){
            type = ItemType.StrenghtGloves;
            name = "Luvas de força🥊💪";
            id = "strenghtGloves";
        }
        public int strenghtBonus = 5;
        public void equipItem(PC player){
            player.Strenght += strenghtBonus;
            Console.WriteLine("Luvas de força Equipado");
        }


    }
}