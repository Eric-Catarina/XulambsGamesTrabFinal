using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    internal abstract class Active : Item, IUsable
    {

        public enum ItemType{
            StrenghtPotion,
            CritPotion,
            HealthPotion,
            

        }
        public ItemType itemType;
        public bool canBeUsedUsed(PC who)
        {
            return true;
        }

        public void use(PC player)
        {
            
        }
    }
}