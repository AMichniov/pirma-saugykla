using System;

namespace _12_paskaita
{
    class Student : Person
    {
        private int _age;
        private int _id;

        public Student(string name, string surName,int age, int id) : base(name, surName)
        {
            _age = age;
            _id = id;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{_name} {_surName} {_age} {_id}");
        }
    }
}
