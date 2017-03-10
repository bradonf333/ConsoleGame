using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class Attack
    {
        public Attack(Item item, Monster monster)
        {
            if (monster.monstHealth > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Monster Health = {0}", monster.monstHealth);
                Console.WriteLine("You attack the {0} with the {1}", monster.monstName, item.itemName);
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(".");
                    System.Threading.Thread.Sleep(200);
                }
                Console.WriteLine();
                Console.WriteLine("The {0} does {1} damage!!", item.itemName, item.itemDamage);
                monster.monstHealth -= item.itemDamage;
                Console.WriteLine("Monster {0} now has {1} health", monster.monstName, monster.monstHealth);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You have killed the {0}", monster.monstName);

            }
        }//End attack method
    }
}
