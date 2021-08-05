using System;

namespace evenodd
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter number =");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("number is even " + number);
            }
            else
            {
                Console.WriteLine("number is odd " + number);
            }
        }
    }
}
