using System;

namespace _14_paskait
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Abstrakti klasė "Number" turi turėti: 
            //- protected int tipo masyvą - masyvo dydis(atsitiktinis skaičius, 20 - 200 elementų)
            //- public abstract metodą Generate()
            //- public metodą GetSum() - grąžina masyvo elementų sumą

            //- Sukuri kitas klases, kurios paveldi "Number" klasę: 
            //- "PossitiveNumber" - implementuoja "Generate" metodą ir užpildo masyvą teigiamais
            // atsitiktiniais(atsitiktinio skaičiaus max reikšmė - 1000) skaičiais
            //○ "EvenNumber" - "Generate" metode užpildo masyvą lyginiais skaičiais
            //○ "OddNumber" - "Generate" metode užpildo masyvą nelyginiais skaiciais
            //○ "NegativeNumber" - "Generate" metode užpildo masyvą neigiamais skaičiais

            //- "Program" klasėje sukurti statinį metodą, kuris priema "Number" tipo parametrą ir:
            //- Parametro kintamajam kviečia metodą "Generate"
            //- Metodo getSum() rezultatą išveda į konsolę
            //- Main metode sukurti įvarių skaičių tipų egzempliorių ir su jais iškviesti anksčiau apsirašytą statinį metodą

            var skaiciai = new PossitiveNumber();
            var skaiciai1 = new EvenNumber();
            var skaiciai2 = new NegativeNumber();
            var skaiciai3 = new OddNumber();

            Info(skaiciai);
            Info(skaiciai1);
            Info(skaiciai2);
            Info(skaiciai3);

            Console.WriteLine("PossitiveNumber: ");
            skaiciai.Print();
            Console.WriteLine("\nEvenNumber: ");
            skaiciai1.Print();
            Console.WriteLine("\nNegativeNumber: ");
            skaiciai2.Print();
            Console.WriteLine("\nOddNumber: ");
            skaiciai3.Print();
        }

        static void Info(Number numb)
        {
            numb.Generate();
            Console.WriteLine(numb.GetSum());
        }
    }
}