using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            int Factorial = 1;
            int Number;
            Console.Write("Enter fact number: ");
            Number = int.Parse(Console.ReadLine());
            for (j = 1; j <= Number; j++)
            {
                Factorial = Factorial * j;
            }
            Console.Write("Factorial " + Number + " is: " + Factorial);
        }
    }
}
