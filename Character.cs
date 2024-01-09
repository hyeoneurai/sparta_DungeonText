using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static sparta.Program;

namespace sparta
{
    internal class Character
    {
        string name;
        string job;
        int level;
        int attack;
        int defense;
        int health;
        int gold;
        int addAtt;
        int addDef;
        List<Item> itemList = new List<Item>();


        public Character(string name, string job, int level, int attack, int defense, int health, int gold, List<Item> itemList)
        {
            this.name = name;
            this.job = job;
            this.level = level;
            this.attack = attack + addAtt;
            this.defense = defense + addDef;
            this.health = health;
            this.gold = gold;
            this.itemList = itemList;
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Job
        {
            get { return job; }
            set { job = value; }
        }

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }


        public void BuyItem(Item item)
        {
            itemList.Add(item);
            
            Gold -= item.Price;
        }

        public int GetItemCount()
        {
            return itemList.Count;
        }

        public void OpenInventory()
        {
            int idx = 0;
            foreach(Item item in itemList)
            {
                //if (item.IsEquipped == false)
                //{
                Console.WriteLine("{0} \t {1} \t {2} \t {3}", idx, item.Name,item.Value, item.Price, item.Comm);
                //}
                //else
                //{
                //    Console.WriteLine("[E]{0} \t {1} \t {2} \t {3}", item.Name, item.Value, item.Price, item.Comm);
                //}
                idx++;
            }
        }
        
        public void EquipItem(int itemIdx)
        {
            Item item = itemList[itemIdx];
            Console.WriteLine("{0}번 {1}을 장착합니다", itemIdx + 1, item.Name);
            switch(item.Type)
            {
                case 0 :
                    addAtt += item.Value;
                    break;
                case 1 :
                    addDef += item.Value;
                    break;
            }
        }
    }
}

