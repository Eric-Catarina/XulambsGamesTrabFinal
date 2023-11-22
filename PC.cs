using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    internal abstract class PC
    {
        protected int strenght;
        //descomentar quando Weapon for implementada
        //protected Weapon weapon;
        protected string id;
        //descomentar quando Item for implementada
        //List<int> inventory;

        public int Strenght {  get { return strenght; } 
            set { strenght = value; } 
        }

        public string Id { get { return id; } 
            set { id = value; }
        }

        //implementar parametros e returns quando implementados
       /* public void attack(other:Enemy)
        {

        }

        public string GetID()
        {

            return id;
        }

        public bool EquipWeapon(WeakReference:Weapon)
        {

            
        }

        public void UseItem(IDisposable:int)
        {


        }*/

    }
}