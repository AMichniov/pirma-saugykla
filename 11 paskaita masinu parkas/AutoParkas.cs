using System.Collections.Generic;
using System.Text;

namespace _11_paskaita_uzduotis
{
    class AutoParkas
    {
        //   private List<Automobilis> MasinuSarasas = new List<Automobilis>();
        private List<Automobilis> MasinuSarasas;


        public AutoParkas()
        {
            MasinuSarasas = new List<Automobilis>();
        }

        public void PridetiAutom(Automobilis masina)
        {
            MasinuSarasas.Add(masina);
        }

        public override string ToString()
        {
            //   string visosMasinos = "";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Skaicius: " + MasinuSarasas.Count.ToString());
            sb.AppendLine("Pirma masina: " + MasinuSarasas[0].ToString());
            sb.AppendLine("Paskutine masina: " + MasinuSarasas[MasinuSarasas.Count - 1].ToString());
            sb.AppendLine("Visos masinos: ");
            foreach (var item in MasinuSarasas)
            {
                //  visosMasinos += $"\t{item}\n";
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();

        }
    }

}




//foreach (var item in MasinuSarasas)
//{
//    //  visosMasinos += $"\t{item}\n";
//    visosMasinos.Append($"\n{item}");
//}

//return $"masinu kiekis: {MasinuSarasas.Count}\n" +
//    $"Pirma masina: {MasinuSarasas[0]}\n" +
//    $"Paskutine masina: {MasinuSarasas[MasinuSarasas.Count-1]}\n" +
//    $"Visasos masinos:\n {visosMasinos}";