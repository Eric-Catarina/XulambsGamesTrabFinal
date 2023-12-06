using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    internal class HealthPotion : Active
    {

        public HealthPotion()
        {
            type = Item.ItemType.HealthPotion;
            name = "Poção De Cura🩸";
        }
       
        public bool canBeUsedUsed(PC who)
        {
            return true;
        }

        public void use(PC player)
        {
            Console.WriteLine("Poção de Cura usada, recuperou +30% de saude");
            player.hp += 30f;
        }
    }
}