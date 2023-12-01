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
            if (w.type == Weapon.WeaponType.Sword && strenght > w.weight){
                switchWeapon(w);
            
                Console.WriteLine("Você equipou a espada com sucesso");
                return true;
            }

            else if (w.type == Weapon.WeaponType.Sword && strenght < w.weight){
                Console.WriteLine("Essa espada é pesada demais para você");
                return false;
            }

            if (w.type == Weapon.WeaponType.Bow){
                Console.WriteLine("Você equipou o arco com sucesso");
                switchWeapon(w);
                return true;
            }

            if (w.type == Weapon.WeaponType.Dagger  && charType == CharacterType.Elfo){
                Console.WriteLine("Elfos não podem usar adagas");
                return false;
            }

            else if (w.type == Weapon.WeaponType.Dagger && charType != CharacterType.Elfo){
                Console.WriteLine("Você equipou a adaga com sucesso");
                switchWeapon(w);
                return true;
            }

            return false;
        }

        private void switchWeapon(Weapon w){
            if (weapon != null){
                strenght -= weapon.strenght;
            }
            weapon = w;
            strenght += weapon.strenght;
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