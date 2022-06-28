namespace _11_paskaita_uzduotis
{
    class Automobilis
    {
        protected readonly string _valstNr;
        protected readonly string _marke;

        public Automobilis(string valstNr, string marke)
        {
            _valstNr = valstNr;
            _marke = marke;

        }
        public Automobilis()
        {

        }

        public override string ToString()
        {
            return $"{_valstNr} {_marke}";
        }
    }

}
