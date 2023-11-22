using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud{
    internal class Paladin: PC{
        public Paladin(){
        }
        public void attack(Enemy other){
            other.TakeDamage(strenght);
        }


    }
}