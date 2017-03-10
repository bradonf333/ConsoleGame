using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class Monster
    {
        public int monstHealth, monstAttack;
        public string monstName;

        public Monster(int health, string name)
        {
            this.monstHealth = health;
            this.monstName = name;
        }

        public void MonstInfo(Monster monster)
        {
            Console.WriteLine("::::: Monster Info :::::");
            Console.WriteLine("Name:\t" + monster.monstName);
            Console.WriteLine("Health:\t" + monster.monstHealth);
            Console.WriteLine("Attack:\t1-15");
        }

        public int MonsterAttackPower()
        {
            Random randPower = new Random();
            int attPower = randPower.Next(1, 16);
            return attPower;

        }

        public void MonstAttack(int atkPower, Player player, Monster monst)
        {
            if (player.playerHealth > 0)
            {
                Console.WriteLine();
                player.playerHealth = player.playerHealth - atkPower;
                Console.WriteLine("Your Health = {0}", player.playerHealth);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You have been killed! Game Over");
            }
        }//End attack method

    }//end Monster Class
}
