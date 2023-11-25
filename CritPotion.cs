using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    internal abstract class CritPotion : Active
    {

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
            player.critChance += 30f;
        }
    }
}