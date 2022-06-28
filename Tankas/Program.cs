using System;

namespace Tankas
{
    class Program
    {
        static void Main(string[] args)
        {
            var tankas = new NaujasTankas();

            Console.WriteLine("Vazioti i preki: 8\n" +
                "Vazioti atga: 5\n" +
                "Vazioti i desine: 6\n" +
                "Vazioti i kaire: 4\n" +
                "suvis: 7\n" +
                "info: 9\n" +
                "baikti: y\n");

            while (true)
            {
                //Console.WriteLine("Siaure: " + tankas.Siaure);
                //Console.WriteLine("Rytai: " + tankas.Rytai);
                //Console.WriteLine("Pietus: " + tankas.Pietus);
                //Console.WriteLine("Vakarai: " + tankas.Vakarai);
                //Console.WriteLine("\n//////////////// pries");



                Console.Write("Iveskite komanda: \n");
                var veiksmas = Console.ReadLine();

                switch (veiksmas)
                {
                    case "8":
                        tankas.VaziotiPirmin(tankas.Kryptis);
                        break;
                    case "5":
                        tankas.VaziotiAtgal(tankas.Kryptis);
                        break;
                    case "6":
                        tankas.Desinen();
                        break;
                    case "4":
                        tankas.Kairen();
                        break;
                    case "7":
                        tankas.Boom();
                        break;
                    case "9":
                        tankas.Info();
                        break;
                }

                if (tankas.Kuras == 0)
                {
                    Console.WriteLine("zaidimas baiktas");
                    return;
                }
                if (veiksmas == "y")
                {
                    return;
                }
            }



        }
    }
}
