using System;

namespace _14_paskait
{
    class NegativeNumber : Number
    {

        public override void Generate()
        {
            for (int i = 0; i < _numbers.Length; i++)
            {

                _numbers[i] = rnd.Next(1000) * (-1);

            }
        }

    }
}