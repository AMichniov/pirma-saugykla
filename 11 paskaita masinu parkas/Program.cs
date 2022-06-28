using System;
using System.Text;

namespace _11_paskaita_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Sukurti klasę Automobilis, su dviem laukais: valstNr, marke.
            * Klasėje perrašyti toString metodą, kuris grazina su automobiliu susijusia informacija.
            Sukurti klasę AutoParkas kuris turi kintamaji savyje laikanti sarasa automobilio objektu.
            AutoParkas taip pat perrašo metoda toString ir grąžiną info apie automobilius:
            - kiek automobilių,
            - koks pirmas sarase,
            - koks paskutinis sarase,
            - visų automobilių info*/

            var mazda = new Automobilis("KRJ555", "MAZDA");
            var opel = new Automobilis("JUY479", "OPEL");
            var bmv = new Automobilis("HRF523", "BMV");
            var tayota = new Automobilis("PLI224", "TAYOTA");

            AutoParkas naujasParkas = new AutoParkas();

            naujasParkas.PridetiAutom(mazda);
            naujasParkas.PridetiAutom(opel);
            naujasParkas.PridetiAutom(bmv);
            naujasParkas.PridetiAutom(tayota);

              Console.WriteLine(naujasParkas.ToString());
           // naujasParkas.ToString();
        }
    }

}
