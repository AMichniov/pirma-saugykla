using System;

namespace _14_paskait
{
    abstract class Number
    {
        protected readonly int[] _numbers;
        protected readonly Random rnd;

        public Number()
        {
            rnd = new Random();
            _numbers = new int[rnd.Next(20, 200)];
                        
        }
        public abstract void Generate();

        public int GetSum()
        {
            int suma = 0;

            foreach (var item in _numbers)
            {
                suma += item;
            }
            return suma;
        }

        public void Print()
        {
            foreach (var item in _numbers)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
