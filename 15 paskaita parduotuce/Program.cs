using System;
namespace _15_paskaita_parduotuce
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sukurti parduotuvę, kuri parduoda saldainius, knygas, puodukus.
            //Jie visi turi pavadinimą, kiekį. Programa turėtų nepasibaigti įrašius tik vieną komandą,
            //turėtų leisti kelias.Reikia panaudoti objektinį programavimą.

            //Galimos komandos konsolėje:
            //"List" išspausdina informacija, ką galima nusipirkti parduotuvėje, koks kiekis ir kokios
            //kainos.Išpirktų produktų neturėtų rodyti.
            //"Buy Candy 20" - turėtų nupirkti visus egzistuojančius jeigu toks item egzistuoja parduotuvėje
            //ir yra toks kiekis. Jei ne, turėtų parodyti atitinkamą žinutę.
            //"Add Cup 30" - turėtų papildyti parduotuvę su atitinkamu produktu ir kiekiu.Tai turętų atsivaizduoti ir "List" komandoje.
            //Jei tokiu produktų jau yra, papildyti.

            var candy = new Candy($"{Goods.candy}", 55, 0.5);
            var book = new Book($"{Goods.book}", 30, 8);
            var cup = new Cup($"{Goods.cup}", 28, 4);

            var user1 = new User(500);

            var shop = new Shop();

            shop.Add(candy);
            shop.Add(book);
            shop.Add(cup);


            shop.Info();

            Console.WriteLine("\nShop Info press 0:");
            Console.WriteLine("Shop Info User 9:\n");
            Console.WriteLine("Add money User 8:\n");
            Console.WriteLine($"pasirinkite prekes pagal Id:\n" +
               $"1: {Goods.candy}\n" +
               $"2: {Goods.book}\n" +
               $"3: {Goods.cup}\n");
            Console.WriteLine("///////////////////////////////////");

            // pasirenkam preke
                      var comand = Console.ReadLine();

            // kintamasis kad pasirinkti prekes kategorija
            Prekes prek1;
            // ////////

            while (comand != "y")
            {
             
                switch (comand)
                {
                    case "1":
                        prek1 = candy;
                        AddBuy(prek1, user1);

                        break;
                    case "2":
                        prek1 = book;
                        AddBuy(prek1, user1);
                        break;
                    case "3":
                        prek1 = cup;
                        AddBuy(prek1, user1);
                        break;
                    case "y":
                        comand = "y";
                        break;
                }
                if (comand == "0")
                {
                    shop.Info();
                }

                if (comand == "9")
                {
                    Console.WriteLine("User balance: " + user1.ShowBalance());
                }

                if (comand == "8")
                {
                    Console.WriteLine("Kiek pinigu pridety?");
                    double money = double.Parse(Console.ReadLine());

                    user1.Topup(money);
                }

                Console.WriteLine("\npasirinkti prekes Id arba veiksma");
                Console.WriteLine("Exit press: y");
                comand = Console.ReadLine();

            }
        }

        static void AddBuy(Prekes prek1, User user1)
        {
            Console.WriteLine($"Prekes pavadinimas: {prek1.Name()}\n");

            Console.WriteLine("Buy press 1");
            Console.WriteLine("Add press 2");
            var addBuy = Console.ReadLine();

            Console.WriteLine("Kiekis: ");
            var kiekis = int.Parse(Console.ReadLine());

            Prek(prek1, addBuy, kiekis, user1);
        }
        static void Prek(Prekes prek, string com, int quiti, User user)
        {
            switch (com)
            {
                case "1":
                    prek.Buy(quiti, user);
                    break;
                case "2":
                    prek.Add(quiti);

                    break;
            }
        }

    }
}
