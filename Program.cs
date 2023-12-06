using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int fightsWon = 0;
            bool gameHappening = true;

            PC player = SelectClass();
            Weapon armaAtual = SelectWeapon(player);
            //player.PedirAcao();

            while (gameHappening)
            {
                Console.WriteLine("Ate o momento voce venceu um total de " + fightsWon + " combates\n");
                Batalha(player, ref gameHappening);
                fightsWon++;
            }

            Console.WriteLine("Sua epica jornada na masmorra infelizmente chegou ao fim quando um oponente te decapitou, voce conseguiu derrotar " + fightsWon + " criaturas");

        }

        //loop de batalha
        static void Batalha(PC player, ref bool gameHappening)
        {

            Enemy inimigo = new Enemy(player);

            var random = new Random();

            //seleciona quem sera o proximo oponente com quem o player lutara
            switch (random.Next(1, 3))
            {
                case 1:
                    inimigo = new Goblin(player);
                    break;

                case 2:
                    inimigo = new Orc(player);
                    break;
            }

            bool inCombat = true;

            while (inCombat)
            {

                player.PedirAcao();

                if (inimigo.Hp <= 0) inCombat = false;

                inimigo.Attack(player);


                if (player.hp <= 0)
                {
                    inCombat = false;
                    gameHappening = false;
                }

            }

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