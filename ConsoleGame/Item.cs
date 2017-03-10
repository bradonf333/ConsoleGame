using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    /*
     * Add uses to the items.
     * Can only be used 4 times before it breaks or something.
     * 
     */
    public class Item
    {
        public int itemID, itemDamage;
        public string itemName, itemDesc;

        public Item(int id, string name, string desc, int damage)
        {
            this.itemID = id;
            this.itemName = name;
            this.itemDesc = desc;
            this.itemDamage = damage;
        }

        public void ItemInfo(Item item)
        {
            Console.WriteLine("Item Info");
            Console.WriteLine("Name: " + item.itemName);
            Console.WriteLine("Desc: " + item.itemDesc);
            Console.WriteLine("Damage: " + item.itemDamage);
        }
    }
}
