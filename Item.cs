using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sparta
{

    public class Item
    {
        private string name;
        private int type;   // 0 : 무기    1 : 방어구
        private int value;
        private int price;
        private string comm;
        //private bool IsIsEquipped;
        //private bool getItem;

        public string Name
        {
            get { return name; }
        }

        public int Type
        {
            get { return type; }
        }

        public int Value
        {
            get { return value; }
        }

        public int Price
        {
            get { return price; }
        }

        public string Comm
        {
            get { return comm; }
        }

        //public bool IsEquipped
        //{
        //    get { return IsEquipped; }
        //    set { IsEquipped = value; }
        //}

        //public bool GetItem
        //{
        //    get { return getItem; }
        //    set { getItem = value; }
        //}
        
    }

    internal class IronArmor : Item
    {
        private string name;
        private int type;
        private int value;
        private int price;
        private string comm;
        //private bool isEquipped;
        //private bool getItem;

        public IronArmor()
        {
            name = "무쇠 갑옷";
            type = 0;
            value = 5;
            price = 1500;
            comm = "무쇠로 만들어져 튼튼한 갑옷입니다.";
            //this.IsEquipped = false;
            //this.GetItem = false;
        }
    }

    internal class NoviceArmor : Item 
    {
        private string name;
        private int type;
        private int value;
        private int price;
        private string comm;
        //private bool isEquipped;
        //private bool getItem;

        public NoviceArmor()
        {
            this.name = "수련자 갑옷";
            this.type = 0;
            this.value = 5;
            this.price = 1000;
            this.comm = "수련에 도움을 주는 갑옷입니다.";
            //this.isEquipped = false;
            //this.getItem = false;
        }
    }

    internal class SpartaArmor : Item
    {
        private string name;
        private int type;
        private int value;
        private int price;
        private string comm;
        //private bool isEquipped;
        //private bool getItem;

        public SpartaArmor()
        {
            this.name = "스파르타갑옷";
            this.type = 0;
            this.value = 15;
            this.price = 3500;
            this.comm = "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.";
            //this.IsEquipped = false;
            //this.GetItem = false;
        }
    }

    internal class OldSword : Item
    {
        private string name;
        private int type;
        private int value;
        private int price;
        private string comm;
        //private bool isEquipped;
        //private bool getItem;

        public OldSword()
        {
            this.name = "낡은 검";
            this.type = 1;
            this.value = 2;
            this.price = 600;
            this.comm = "쉽게 볼 수 있는 낡은 검 입니다.";
            //this.isEquipped = false;
            //this.getItem = false;
        }
    }

    internal class BronzeAx : Item
    {
        private string name;
        private int type;
        private int value;
        private int price;
        private string comm;
        //private bool isEquipped;
        //private bool getItem;

        public BronzeAx()
        {
            this.name = "청동 도끼";
            this.type = 1;
            this.value = 5;
            this.price = 1500;
            this.comm = "어디선가 사용됐던거 같은 도끼입니다.";
            //this.isEquipped = false;
            //this.getItem = false;
        }
    }

    internal class SpartanSpear : Item
    {
        private string name;
        private int type;
        private int value;
        private int price;
        private string comm;
        //private bool isEquipped;
        //private bool getItem;

        public SpartanSpear()
        {
            this.name = "스파르타 창";
            this.type = 1;
            this.value = 7;
            this.price = 2000;
            this.comm = "스파르타의 전사들이 사용했다는 전설의 창입니다.";
            //this.isEquipped = false;
            //this.getItem = false;
        }
    }
}
