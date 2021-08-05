using System;

namespace HarmonicProgresssion
{
    class Program
    {
        static double nthharmonic(int N)
        {
            float Hp = 1;

            for (int i = 2; i < N; i++)
            {
                Hp += (float)1 / i;
            }
            return (Hp);
        } 

        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            
            Console.WriteLine(nthharmonic(N));

        }
    }
}
