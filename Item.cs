using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    internal abstract class Item
    {
        public string name;
        protected int strength;
        protected string? id;

        public enum ItemType{
            CritGloves,
            StrenghtGloves,
            StrenghtPotion,
            CritPotion,
            HealthPotion,

        }

        public ItemType type;

        public void use(PC player)
        {
            Console.WriteLine("Tentou usar pelo ITEM");
        }        
        
        public void equipItem(PC player)
        {
            Console.WriteLine("Tentou equipar pelo ITEM");
        }

        public string getID(){
            return id;
        }

        public bool canBeUsedUsed(PC who)
        {
            throw new NotImplementedException();
        }
    }
}