using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sparta
{
    internal class Shop
    {
        static List<Item> shopItemList = new List<Item>();

        public void shopUpdate()
        {
            shopItemList.Add(new IronArmor());
            shopItemList.Add(new IronArmor());
            shopItemList.Add(new IronArmor());
            shopItemList.Add(new IronArmor());
            shopItemList.Add(new IronArmor());

        }

    }
}
