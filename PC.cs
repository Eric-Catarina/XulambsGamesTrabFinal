using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    internal abstract class PC : IObservador
    {
        protected int strenght;
        public float critChance;
        public Weapon weapon;
        protected string? id;
        List<Item>? inventory;

        public static Action<PC> OnHit;

        public enum CharacterType{
            Paladino,
            Elfo
        }
        public CharacterType charType;



        public int Strenght {  get { return strenght; } 
            set { strenght = value; } 
        }

        public string Id { get { return id; } 
            set { id = value; }
        }

        //implementar parametros e returns quando implementados
        public void attack(Enemy other)
        {

        }

        public string GetID()
        {

            return id;
        }

        public bool equipWeapon(Weapon w){
            if (w.type ==Weapon.WeaponType.Sword && strenght > w.weight){
                weapon = w;
                strenght += weapon.strenght;
                return true;
            }
            if (w.type == Weapon.WeaponType.Dagger || w.type == Weapon.WeaponType.Bow){
                weapon = w;
                strenght += weapon.strenght;
                return true;
            }

            return false;
        }

        public void UseItem(int pos)
        {


        }

        public void Avisar(IInimigoObservado personagem)
        {
            Console.WriteLine("O PC está ciente que o inimigo morreu");
        }
        
    }
}