using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    internal class StrenghtPotion : Active
    {
        public StrenghtPotion()
        {
            type = Item.ItemType.StrenghtPotion;
            name = "Poção de Força💪";
        }

        public enum ItemType{
            StrenghtPotion,
            CritPotion,
        }
        public bool canBeUsedUsed(PC who)
        {
            return true;
        }

        public void use(PC player)
        {
            Console.WriteLine("Poção de Força usada, +20 de força");
            player.Strenght += 20;
        }
    }
}