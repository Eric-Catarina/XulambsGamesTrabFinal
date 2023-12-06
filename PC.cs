using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    internal abstract class PC : IObservador
    {


        public int strenght, hp, maxHp;
        public float critChance;
        public Weapon weapon;
        public Enemy? enemy;
        protected string? id;
        public List<Item>? inventory = new List<Item>();

        public static Action<PC> OnHit;

        public enum CharacterType
        {
            Paladino,
            Elfo
        }
        public CharacterType charType;
        

        public int Strenght
        {
            get { return strenght; }
            set { strenght = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }


        public virtual void attack(Enemy other)
        {
            if (other == null)
            {
                enemy = SpawnEnemy();
                other = enemy;
            }
            if (other.GetHp() <= 0)
            {
                enemy = SpawnEnemy();
                other = enemy;
            }
            
            var random = new Random();
            if (random.Next(1, 100) < critChance)
            {
                Console.WriteLine("Você causou " + strenght * 2 + " de dano com um acerto crítico!!!" );
                other.TakeDamage(strenght * 2);
            }
            else
            {
                Console.WriteLine("Você causou " + strenght + " de dano");
                other.TakeDamage(strenght);
            }
            
            TakeDamage(other.dano);

            Console.WriteLine("Você está com " + hp + "/" + maxHp + " de vida❤️.");
            //Console.WriteLine("Voce foi atacado, o inimigo te causou" + other.dano + " pontos de dano");
        }

        public string GetID()
        {

            return id;
        }

        public bool equipWeapon(Weapon w)
        {
            if (w.type == Weapon.WeaponType.Sword && strenght > w.weight)
            {
                switchWeapon(w);

                Console.WriteLine("Você equipou a espada com sucesso");
                return true;
            }

            else if (w.type == Weapon.WeaponType.Sword && strenght < w.weight)
            {
                Console.WriteLine("Essa espada é pesada demais para você");
                return false;
            }

            if (w.type == Weapon.WeaponType.Bow)
            {
                Console.WriteLine("Você equipou o arco com sucesso");
                switchWeapon(w);
                return true;
            }

            if (w.type == Weapon.WeaponType.Dagger && charType == CharacterType.Elfo)
            {
                Console.WriteLine("Elfos não podem usar adagas");
                return false;
            }

            else if (w.type == Weapon.WeaponType.Dagger && charType != CharacterType.Elfo)
            {
                Console.WriteLine("Você equipou a adaga com sucesso");
                switchWeapon(w);
                return true;
            }

            return false;
        }

        private void switchWeapon(Weapon w)
        {
            if (weapon != null)
            {
                strenght -= weapon.strenght;
            }
            weapon = w;
            strenght += weapon.strenght;
        }

        public void UseItem()
        {
            Console.WriteLine("Escolha um dos itens do inventário abaixo para usar(use o índice)");
            ShowInventory();
            string input = Console.ReadLine();
            int index = 0;
            if (int.TryParse(input, out index))
            {
                if (index >= inventory.Count )
                {
                    Console.WriteLine("Escolha inválida");
                    return;
                }
                if (inventory[index].type == Item.ItemType.StrenghtGloves)
                {
                    inventory[index] = new StrenghtGloves();
                    StrenghtGloves luvas = (StrenghtGloves)inventory[index];
                    luvas.equipItem(this);
                    inventory.RemoveAt(index);
                    return;
                }

                if (inventory[index].type == Item.ItemType.CritGloves)
                {
                    inventory[index] = new CritGloves();
                    CritGloves luvas = (CritGloves)inventory[index];
                    luvas.equipItem(this);
                    inventory.RemoveAt(index);
                    return;
                }

                if (inventory[index].type == Item.ItemType.StrenghtPotion)
                {
                    inventory[index] = new StrenghtPotion();
                    StrenghtPotion potion = (StrenghtPotion)inventory[index];
                    potion.use(this);
                    inventory.RemoveAt(index);
                    return;
                }

                if (inventory[index].type == Item.ItemType.CritPotion)
                {
                    inventory[index] = new CritPotion();
                    CritPotion potion = (CritPotion)inventory[index];
                    potion.use(this);
                    inventory.RemoveAt(index);
                    return;
                }
                
                if (inventory[index].type == Item.ItemType.HealthPotion)
                {
                    inventory[index] = new HealthPotion();
                    HealthPotion potion = (HealthPotion)inventory[index];
                    potion.use(this);
                    inventory.RemoveAt(index);
                    return;
                }

                inventory[index].use(this);
                inventory.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Escolha inválida");
            }

        }

        public void Avisar(IInimigoObservado personagem)
        {
            Console.WriteLine("O PC está ciente que o inimigo morreu💀");
            // Spawnar Outro Inimigo
        }

        public void ShowStats()
        {
            Console.WriteLine("Força💪: " + strenght);
            Console.WriteLine("Chance de acerto crítico🩸: " + critChance);
            Console.WriteLine("HP❤️: " + hp + "/" + maxHp);
            Console.WriteLine("Arma equipada⚔️: " + weapon.type);
        }

        public void PedirAcao()
        {
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Atacar 🗡️🗡️🗡️");
            Console.WriteLine("2 - Usar item🧪");
            Console.WriteLine("3 - Ver status👨‍⚕️");
            Console.WriteLine("4 - Ver inventário🎒");
            Console.WriteLine("5 - Equipar arma⚔️");
            Console.WriteLine("6 - Sair❌(Fechar o jogo)");
            string input = Console.ReadLine();
            Console.Clear();
            ExecutarAcao(input);
        }

        public void ExecutarAcao(string acao)
        {
            switch (acao)
            {
                case "1":
                    attack(enemy);
                    PedirAcao();
                    break;
                case "2":
                    UseItem();
                    PedirAcao();
                    break;
                case "3":
                    ShowStats();
                    PedirAcao();
                    break;
                case "4":
                    ShowInventory();
                    PedirAcao();
                    break;
                case "5":
                    Program.SelectWeapon(this);
                    PedirAcao();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Escolha inválida");
                    PedirAcao();
                    break;
            }
        }

        public void ShowInventory()
        {
            if (inventory == null)
            {
                Console.WriteLine("Inventário vazio");
                return;
            }
            foreach (Item item in inventory)
            {
                Console.WriteLine(item.name + ", ");
            }
        }
        public void TakeDamage(int damage)
        {
            hp -= damage;
            if (hp <= 0)
            {
                Console.WriteLine("Sua epica jornada na masmorra infelizmente chegou ao fim quando um oponente te decapitou");
                Environment.Exit(0);
            }
        }
        // Select random goblin or orc with 50% chance
        public Enemy SpawnEnemy()
        {
            var random = new Random();
            int enemyType = random.Next(1, 3);
            if (enemyType == 1)
            {
                enemy = new Goblin(this);
            }
            else
            {
                enemy = new Orc(this);
            }

            //Console.WriteLine("Um " + enemy.type + " apareceu diante de ti");
            return enemy;
        }
    }
}