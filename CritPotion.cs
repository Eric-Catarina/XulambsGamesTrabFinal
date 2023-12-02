using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    internal class CritPotion : Active
    {

        public CritPotion(){
            type = Item.ItemType.CritPotion;
            name = "Poção de Crítico🩸";
        }
       
        public bool canBeUsedUsed(PC who)
        {
            return true;
        }

        public void use(PC player)
        {
            Console.WriteLine("Poção de Crítico usada, +30% de chance de crítico");
            player.critChance += 30f;
        }
    }
}