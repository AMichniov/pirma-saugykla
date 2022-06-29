namespace _12_paskaita
{
    abstract class Person
    {
        protected readonly string _name;
        protected readonly string _surName;

        protected Person(string name, string surName)  // protected geriau nes person klase mes nekuriam  o tik paveldom
        {
            _name = name;
            _surName = surName;
        }

        public abstract void PrintInfo();
    }
}
