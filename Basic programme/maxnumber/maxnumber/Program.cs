using System;

namespace maxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("enter 1st number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 3rd number");
            num3= Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("number 1 is largest" + num1);


            }
            else if (num2 > num3)
            {
                Console.WriteLine("number 2 is largest" + num2);

            }
            else
            {
                Console.WriteLine("number 3 is largest" + num3);
            }


        }
    }
}
