using System;

namespace _12_paskaita
{
    class Lecturer : Person
    {
        private int _birthday;
        private int _code;

        public Lecturer(string name, string surName,int birthday, int code) : base(name, surName)
        {
            _birthday = birthday;
            _code = code;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{_name} {_surName} {_birthday} {_code}");
        }
    }
}
