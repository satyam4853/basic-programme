using System;

namespace swapnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("number1 is" + number1);
            Console.WriteLine("number2 is" + number2);
            number1 = number1 * number2;
            number2 = number1 / number2;
            number1 = number1 / number2;
            Console.WriteLine("after swapping number number1="  +number1 + "number2=" + number2);
        }
    }
}
