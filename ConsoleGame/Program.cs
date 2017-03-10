using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my First Game");
            string userOption = "";
            Console.WriteLine();
            Console.Write("Please enter your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Gender:");
            Console.Write("M = Male\nF = Female\nGender = ");
            string playerGender = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Please select a difficulty:");
            Console.Write("1 - Easy\n2 - Medium\n3 - Hard\n4 - Very Hard\n5 - Almost Impossible");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Difficulty Choice = ");
            string difficulty = Console.ReadLine();
            int health = 0;

            switch (difficulty)
            {
                case "1":
                    health = 100;
                    break;
                case "2":
                    health = 75;
                    break;
                case "3":
                    health = 50;
                    break;
                case "4":
                    health = 25;
                    break;
                case "5":
                    health = 5;
                    break;
            }

            Player player1 = new Player(playerName, playerGender, health);

            List<Item> playerItems = new List<Item>();
            Item item1 = new Item(0, "Small Sword", "Beginning Sword for the game", 5);
            Item item2 = new Item(1, "Small Axe", "Beginning Axe for the game", 10);
            Item item3 = new Item(2, "Dagger", "Beginning Dagger for the game", 2);
            playerItems.Add(item1);
            playerItems.Add(item2);
            playerItems.Add(item3);
            bool dead = false;

            /* --------Complete--------
             * Add class for player info
             * Could have a name & health.
             * -----------------------------
             * More Ideas?
             * Any other things? 
             */

            /*
             * Create multiple monsters using a list like I did with the Items 
             * Then user can pick which monster to attack
             */
            Monster monst1 = new Monster(100, "Jabbawokee");

            while (userOption != "q" && dead != true)
            {
                if (monst1.monstHealth > 0 && player1.playerHealth > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Main Menu:");
                    Console.WriteLine("1 - Item Inventory");
                    Console.WriteLine("2 - Player Info");
                    Console.WriteLine("3 - Monster Info");
                    Console.WriteLine("4 - Attack");
                    Console.WriteLine("Q - Quit");
                    Console.WriteLine();
                    Console.Write("User Option = ");

                    userOption = Console.ReadLine();

                    switch (userOption)
                    {
                        case "1":
                            Console.WriteLine();
                            foreach (var item in playerItems)
                            {
                                item.ItemInfo(item);
                                Console.WriteLine();
                            }
                            break;
                        case "2":
                            Console.WriteLine();
                            player1.PlayerInfo(player1);
                            break;
                        case "3":
                            Console.WriteLine();
                            monst1.MonstInfo(monst1);
                            break;
                        case "4":
                            Console.WriteLine();
                            Console.WriteLine("Pick a weapon to attack with");
                            Console.WriteLine("1 - " + item1.itemName);
                            Console.WriteLine("2 - " + item2.itemName);
                            Console.WriteLine("3 - " + item3.itemName);
                            Console.WriteLine("B - Go back");
                            Console.WriteLine();
                            Console.Write("Weapon Choice = ");
                            string weaponChoice = Console.ReadLine();
                            switch (weaponChoice)
                            {
                                case "1":
                                    Attack attack = new Attack(item1, monst1);
                                    break;
                                case "2":
                                    Attack attack2 = new Attack(item2, monst1);
                                    break;
                                case "3":
                                    Attack attack3 = new Attack(item3, monst1);
                                    break;
                                default:
                                    break;
                            }//end inner WeaponChoiceSwitch
                            Console.WriteLine();
                            if (monst1.monstHealth > 0 && weaponChoice != "b")
                            {
                                Console.WriteLine("Monster {0} attacks!", monst1.monstName);
                                for (int i = 0; i < 15; i++)
                                {
                                    Console.Write(".");
                                    System.Threading.Thread.Sleep(200);
                                }
                                Console.WriteLine();
                                Console.WriteLine("Monster {0} did {1} damage!", monst1.monstName, monst1.MonsterAttackPower());
                                monst1.MonstAttack(monst1.MonsterAttackPower(), player1, monst1);

                            }//End If
                            if (player1.playerHealth <= 0)
                            {
                                dead = true;
                            }
                            else if (monst1.monstHealth <= 0)
                            {
                                userOption = "q";
                            }
                            break;
                        default:
                            break;
                    }//end outer switch
                }//end if MonsterHealth > 0
            }//end While

            if (monst1.monstHealth <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("You have beaten the game! Congratulations");
            }
            else if (player1.playerHealth <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("You have been killed by the {0}!", monst1.monstName);
                Console.WriteLine("Better Luck Next Time");
                dead = true;
            }
            Console.WriteLine();
            Console.WriteLine("Thanks for playing!");
            Console.WriteLine();
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }//End Main Method
    }//End Class Program
}
