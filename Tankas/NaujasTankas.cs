using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tankas
{
    class NaujasTankas
    {
        public int Kuras = 100;
        public int Kulkos = 10;
        public int Soveniuskaiciokle = 0;

        // krepciu suviu kieki skaiciot
        private int SiaureKulka;
        private int RytaiKulka;
        private int PietusKulka;
        private int VakaraiKulka;


        public int Siaure;
        public int Rytai;
        public int Pietus;
        public int Vakarai;

        public string Kryptis = "s";

        List<string> TankoSuviuInfo = new List<string>();
        public int i = 1; // listo skaiciavimuj




        public void SuvisPozicija()
        {

            if (Kryptis == "s")
            {
                SiaureKulka++;
            }
             if (Kryptis == "r")
            {
                RytaiKulka++;
            }
            if (Kryptis == "p")
            {
                PietusKulka++;
            }
            if (Kryptis == "v")
            {
                VakaraiKulka++;
            }
        }

        public void Boom()
        {
            // padetis kur isauta
            IsautaKur();
            // skaicioja kiek isove
            Soveniuskaiciokle++;

            // kokia kryptimi isove
            SuvisPozicija();

            // ///////////
            if (Kulkos > 0)
            {
                Console.WriteLine("\tBoom!!!!!!!!");
                Kulkos--;
            }
            else Console.WriteLine("\tbaigesi kulkos!");

        }

        public void Desinen()
        {
            Console.WriteLine("\tPasukti i desine\n");
            if (Kryptis == "s")
            {
                Kryptis = "r";
            }
            else if (Kryptis == "r")
            {
                Kryptis = "p";
            }
            else if (Kryptis == "p")
            {
                Kryptis = "v";
            }
            else if (Kryptis == "v")
            {
                Kryptis = "s";
            }

        }

        public void Kairen()
        {
            Console.WriteLine("\tPasukti i desine\n");
            if (Kryptis == "s")
            {
                Kryptis = "v";
            }
            else if (Kryptis == "v")
            {
                Kryptis = "p";
            }
            else if (Kryptis == "p")
            {
                Kryptis = "r";
            }
            else if (Kryptis == "r")
            {
                Kryptis = "s";
            }

        }



        public void VaziotiPirmin(string komanda)
        {
            Console.WriteLine("\tVazioja i preki\n");
            switch (komanda)
            {
                case "s":
                    Console.WriteLine("\tkriptis siaure");
                    if (Siaure >= 0 && Pietus == 0)
                    {
                        Siaure++;
                    }
                    else Pietus--;

                    Kuras--;
                    break;
                case "r":
                    Console.WriteLine("\tkryptis rytai");
                    if (Rytai >= 0 && Vakarai == 0)
                    {
                        Rytai++;
                    }
                    else Vakarai--;

                    Kuras--;
                    break;
                case "p":
                    Console.WriteLine("\tkryptis pietus");
                    if (Pietus >= 0 && Siaure == 0)
                    {
                        Pietus++;
                    }
                    else Siaure--;

                    Kuras++;
                    break;
                case "v":
                    Console.WriteLine("\tkryptis vakarai");
                    if (Vakarai >= 0 && Rytai == 0)
                    {
                        Vakarai++;
                    }
                    else Rytai--;

                    Kuras--;
                    break;
            }
        }

        public void VaziotiAtgal(string komanda)
        {
            Console.WriteLine("\tVazioja i atgal\n");
            switch (komanda)
            {
                case "s":
                    Console.WriteLine("\tkryptis siaure");
                    if (Siaure > 0 && Pietus == 0)
                    {
                        Siaure--;
                    }
                    else Pietus++;

                    Kuras--;
                    break;
                case "r":
                    Console.WriteLine("\tkryptis rytai");
                    if (Rytai > 0 && Vakarai == 0)
                    {
                        Rytai--;
                    }
                    else Vakarai++;

                    Kuras--;
                    break;
                case "p":
                    Console.WriteLine("\tkryptis pietus");
                    if (Pietus > 0 && Siaure == 0)
                    {
                        Pietus--;
                    }
                    else Siaure++;

                    Kuras++;
                    break;
                case "v":
                    Console.WriteLine("\tkrytis vakarai");
                    if (Vakarai > 0 && Rytai == 0)
                    {
                        Vakarai--;
                    }
                    else Rytai++;

                    Kuras--;
                    break;


            }
        }
        public void Info()
        {
            Console.WriteLine("\tTanko padetis:");
            // spausdina pozizija
            if (Siaure > 0)
            {
                Console.WriteLine("\tSiaure: " + Siaure);
            }
            if (Rytai > 0)
            {
                Console.WriteLine("\tRytai: " + Rytai);
            }
            if (Vakarai > 0)
            {
                Console.WriteLine("\tVakarai: " + Vakarai);
            }
            if (Pietus > 0)
            {
                Console.WriteLine("\tPietus: " + Pietus);
            }
            // spausdina kripti
            if (Kryptis == "s")
            {
                Console.WriteLine("\tKryptis siaure");
            }
            if (Kryptis == "r")
            {
                Console.WriteLine("\tKryptis rytai");
            }
            if (Kryptis == "p")
            {
                Console.WriteLine("\tKryptis pietus");
            }
            if (Kryptis == "v")
            {
                Console.WriteLine("\tKryptis vakarai");
            }

            // kiek sove
            Console.WriteLine($"\tIsauta soveniu {Soveniuskaiciokle}");

            // kiiek sove i pietus i rytus...
            Console.WriteLine($"\tsove i siaure {SiaureKulka}\n" +
                $"\tsove i rytus {RytaiKulka}\n" +
                $"\tsove i pietus {PietusKulka}\n" +
                $"\tsove i vakarus {VakaraiKulka}\n");

            // kikek buvo isauta konkrecioj pozicijoj
            foreach (var item in TankoSuviuInfo)
            {
                Console.WriteLine(item);
            }
            
        }

        // kikek buvo isauta konkrecioj pozicijoj

        private void IsautaKur()
        {
            
           string index = i.ToString();
            i++;

            TankoSuviuInfo.Add($"{index} suvis  \nkreptis:" );
            if (Siaure == 0 && Pietus == 0 && Rytai == 0 && Vakarai == 0)
            {
                TankoSuviuInfo.Add("\tTanko padetis nuline");
            }

            if (Siaure > 0)
            {

                TankoSuviuInfo.Add($"\tSiaure: {Siaure.ToString()}");
            }
            if (Rytai > 0)
            {

                TankoSuviuInfo.Add($"\tRytai: {Rytai.ToString()}");
            }
            if (Pietus > 0)
            {

                TankoSuviuInfo.Add($"\tPietus: {Pietus.ToString()}");
            }
            if (Vakarai > 0)
            {

                TankoSuviuInfo.Add($"\tVakarai: {Vakarai.ToString()}");
            }

        }




    }


}
