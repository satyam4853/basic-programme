using System;

namespace vowel_consonent
{
    class Program
    {
        static void Main(string[] args)
        {

            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());


            
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {

                Console.WriteLine(" the character is vowel :" +ch);

            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("the charcter is cosonent :" +ch);
            }

            Console.ReadLine();
        }
    }
}
