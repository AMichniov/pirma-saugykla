using System;

namespace _14_paskait
{
    class OddNumber : Number
    {
        public override void Generate()
        {
            for (int i = 0; i < _numbers.Length; i++)
            {

                int sk = rnd.Next(1000);

                if (sk % 2 != 0)
                {
                    _numbers[i] = sk;
                }
                else _numbers[i] = sk + 1;

            }
        }

    }
}