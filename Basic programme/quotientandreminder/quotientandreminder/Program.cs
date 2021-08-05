using System;

namespace quotientandreminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividend = int.Parse(Console.ReadLine());
            
            int divisor = int.Parse(Console.ReadLine());
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Dividend=" + dividend);
            Console.WriteLine("Divisor=" +divisor);
            Console.WriteLine("quotient =" + quotient);
            Console.WriteLine("remainder =" + remainder);
            
        }
    }
}
