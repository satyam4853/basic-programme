using System;

namespace powerof2
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;

            Console.WriteLine("enter power of N within 32");
            N = double.Parse(Console.ReadLine());
            double Table = 0;
            double Result;
            Result = Math.Pow(2, N);
            for (int i = 0; i < N; i++)
            {
                if (Table != Result)
                {
                    Table =Math.Pow(2, i);
                    Console.WriteLine("Table is =" + Table);
                }
                else
                {
                    Console.WriteLine("error");
       }    
            }

        }
    }
}
