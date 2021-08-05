using System;

namespace leapyear
{
    class Program
    {
        static void Main(string[] args)
        {
            int Year;
            Console.WriteLine("enter the year you have to check=");
            Year =int.Parse(Console.ReadLine());
            if ( Year % 400 == 0 || Year % 4==0 )
            {
                Console.WriteLine("the year is Leap year" + Year);

            }
            else if( Year % 100!=0)
            {
                Console.WriteLine("the year is not leap year" + Year);

            }
            else
            {
                Console.WriteLine("the year is no leap year " + Year);
            }

        }
    }
}
