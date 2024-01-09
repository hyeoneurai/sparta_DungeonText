using System.Reflection.Metadata.Ecma335;
using System.Xml;
using static sparta.Program;

namespace sparta
{
    internal class Program
    {
        static string playerName;
        static Character myChar;


        static void Main(string[] args)
        {
            Console.WriteLine("player 닉네임을 입력해주세요 : ");
            playerName = Console.ReadLine();
            myChar = new Character(playerName, "전사", 1, 10, 5, 100, 1500, new List<Item>());
            myChar.BuyItem(new SpartaArmor());
            myChar.BuyItem(new IronArmor());
            myChar.BuyItem(new OldSword());


            MainScene();
        }

        static int CheckVaildAction(int min, int max)    //min과 max사이의 숫자를 골라 선택할 수 있도록 하는 함수
        {
            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" 원하시는 행동을 입력해 주세요");
                Console.WriteLine(">>");
                string input = Console.ReadLine();

                bool parseSuccess = int.TryParse(input, out var ret);
                if (parseSuccess)
                {
                    if (ret >= min && ret <= max)
                    {
                        return ret;
                    }
                }
                Console.WriteLine("잘못된 입력입니다.");
            }
        }
        
        static void MainScene()
        {
            Console.Clear();
            Console.Title = "스파르타 던전";
            Console.WriteLine(" ");
            Console.WriteLine($"{playerName}님 스파르타 마을에 오신걸 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine(" ");
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine(" ");
            int input = CheckVaildAction(1, 3);

            switch (input)
            {
                case 1:
                    CharState();
                    break;
                case 2:
                    OpenInventory();
                    break;
                case 3:
                    OpenShop();
                    break;
            }
        }

        static void CharState()
        {
            Console.Clear() ;

            Console.WriteLine("상태창") ;
            Console.WriteLine("캐릭터의 정보가 표시됩니다") ;
            Console.WriteLine();
            Console.WriteLine($"LV.  {myChar.Level} \n {myChar.Name} ({myChar.Job}) \n공격력 : {myChar.Attack} \n방여력 : {myChar.Defense} \n체  력 :{myChar.Health} \nGold : {myChar.Gold}");
            Console.WriteLine("");
            Console.WriteLine("0. 나가기");
            Console.WriteLine("");

            int input = CheckVaildAction(0, 0);

            switch(input)
            {
                case 0: 
                    MainScene();
                    break;
            }
        }

        static void OpenInventory()
        {
            Console.Clear ();
            if(myChar.GetItemCount() == 0)
            {
                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");
              
            }
            else
            {
                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");
                myChar.OpenInventory();
            }
           
            Console.WriteLine();
            Console.WriteLine("1. 장착 관리 \n2. 나가기");
            Console.WriteLine("");

            int input = CheckVaildAction(1, 2);

            switch (input)
            {
                case 1:
                    // ManagementEquipItem();
                    break;
                case 2:
                    MainScene();
                    break;
            }
        }

        static void OpenShop()
        {
            Console.Clear();

            Console.WriteLine("상점");
            Console.WriteLine("보유 골드");
            Console.WriteLine($"{myChar.Gold} G") ;
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            // shop
            Console.WriteLine();
            Console.WriteLine("1. 아이템 구매 \n2. 나가기");
            Console.WriteLine("");

            int input = CheckVaildAction(1, 2);

            switch (input)
            {
                case 1:
                    // 구매하기
                    break;
                case 2:
                    MainScene();
                    break;
            }
        }

        static void ManagementEquipItem()
        {
            Console.Clear();
            Console.WriteLine("인벤토리 - 장착 관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            myChar.OpenInventory();

        }
    }
}
