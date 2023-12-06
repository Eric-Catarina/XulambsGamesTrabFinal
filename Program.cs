using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    internal class Program
    {
        public int fightsWon = 0;

        static void Main(string[] args)
        {


            PC player = SelectClass();
            Weapon armaAtual = SelectWeapon(player);
            player.PedirAcao();


        }


        static string Get_Input()
        {
            string input = Console.ReadLine();

            return input;
        }

        static PC SelectClass()
        {
            Console.WriteLine("Escolha sua classe: ");
            Console.WriteLine("1 - Paladino \n2 - Elfo");
            PC player = null;
            switch (Get_Input())
            {
                case "1":
                    player = new Paladin();
                    Console.WriteLine("Você escolheu a classe paladino");
                    break;
                case "2":
                    player = new Elf();
                    Console.WriteLine("Você escolheu a classe elfo");
                    break;
                default:
                    Console.WriteLine("Escolha inválida");
                    return SelectClass();
            }
            return player;

        }

        public static Weapon SelectWeapon(PC player)
        {
            Console.WriteLine("Escolha sua arma: ");
            Console.WriteLine("1 - Espada \n2 - Arco \n3 - Adaga");
            Weapon arma = null;
            string input = Get_Input();
            switch (input)
            {
                case "1":
                    arma = new Sword();
                    break;
                case "2":
                    arma = new Bow();
                    break;
                case "3":
                    arma = new Dagger();
                    break;
                default:
                    Console.WriteLine("Escolha inválida");
                    return SelectWeapon(player);
            }
            Console.Clear();
            try
            {
                player.equipWeapon(arma);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            if (player.equipWeapon(arma))
            {
                return arma;
            }
            else
            {
                return SelectWeapon(player);
            }
        }
    }
}