using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    internal abstract class Item
    {
        
        protected int strength;
        protected string? id;


        public string getID(){
            return id;
        }
    }
}