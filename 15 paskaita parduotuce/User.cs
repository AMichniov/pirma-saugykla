namespace _15_paskaita_parduotuce
{
    class User
    {
        protected private double _balane;

        public User(double balance)
        {
            _balane = balance;
        }

        public double Topup(double money)
        {
            return _balane += money;
        }
        public double Down(double money)
        {
            return _balane -= money;
        }

        public double ShowBalance()
        {
            return _balane;
        }
    }
}
