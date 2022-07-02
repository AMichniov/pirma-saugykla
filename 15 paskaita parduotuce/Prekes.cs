using System;

namespace _15_paskaita_parduotuce
{
    class Prekes
    {
        protected string _name;
        protected int _quanti;
        protected double _price;

        public Prekes(string name, int quantity, double price)
        {
            _name = name;
            _quanti = quantity;
            _price = price;

        }

        public string Name()
        {
            return _name;
        }
        public int Quanti()
        {
            return _quanti;
        }

        // info
        public override string ToString()
        {
            //if (_quanti > 0)
            //{
            return $"{_name} liko: {_quanti} kaina: {_price} Eur";
            //}
            //return "";
        }

        // koks likuti prekiu

        private void Balance()
        {
            if (_quanti > 0)
            {
                Console.WriteLine($"{_name} liko: {_quanti}\n");
            }
            else Console.WriteLine($"{_name} neliko\n");


        }
        // ////////////////

        public void Buy(int buy, User user)
        {
            var maxMoney = _price * buy;
            if (user.ShowBalance() < maxMoney)
            {
                Console.WriteLine("Pinigu likutis:");
                Console.WriteLine(user.ShowBalance());
            }

            if (_quanti >= buy && user.ShowBalance() >= maxMoney)
            {
                _quanti -= buy;
                user.Down(maxMoney);

                Console.WriteLine($"nupirkta {buy} ");
                Balance();
            }
            else
            {
                Console.WriteLine("Nepakanka pinigu arba permazas likutis parduotuvei");
                Balance();
                Console.WriteLine("Pinigu liko " + user.ShowBalance());
                Console.WriteLine($"Praikiu kaina: {maxMoney} Eur.");

            }

        }

        // papildyti prekes
        public void Add(int add)
        {
            _quanti += add;

            Console.WriteLine($"Papildyta {_name} {add} vnt. viso: {_quanti}");
        }
    }
}
