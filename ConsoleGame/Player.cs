using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class Player
    {
        public string playerName, playerGender;
        public int playerHealth;

        public Player(string name, string gender, int health)
        {
            this.playerName = name;
            this.playerGender = gender;
            this.playerHealth = health;

        }

        public void PlayerInfo(Player player)
        {
            Console.WriteLine(":::: Player Info ::::");
            Console.WriteLine("Name:\t" + player.playerName);
            Console.WriteLine("Health:\t" + player.playerHealth);
            Console.WriteLine("Gender:\t" + player.playerGender);
        }
    }
}
