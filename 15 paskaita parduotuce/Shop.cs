using System;
using System.Collections.Generic;

namespace _15_paskaita_parduotuce
{
    class Shop 
    {
        protected readonly List<Prekes> ShopList;

        public Shop() 
        {
            ShopList = new List<Prekes>();
          
        }

        public void Add(Prekes prekes)
        {
            ShopList.Add(prekes);
        }

        public void Info()
        {
            Console.WriteLine($"\tParduotuvei visu priakiu yra:");
            foreach (var item in ShopList)
            {
                if (item.Quanti() == 0)
                {
                    continue;
                }
                Console.WriteLine(item.ToString());

            }
            
        }
    }
}
