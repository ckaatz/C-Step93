using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Step93
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my birthday! Month first:");
            int BirthMonth = Convert.ToInt32(Console.ReadLine());
            bool CorrectMonth = BirthMonth == 9;

            while (!CorrectMonth)
            {
                switch (BirthMonth)
                {
                    case 8:
                        Console.WriteLine("So close!");
                        Console.WriteLine("Guess another month:");
                        BirthMonth = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("So close!");
                        Console.WriteLine("Guess another month:");
                        BirthMonth = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        CorrectMonth = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect!");
                        Console.WriteLine("Guess another month:");
                        BirthMonth = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            Console.WriteLine("Correct! Now guess the day:");
            int birthDay = Convert.ToInt32(Console.ReadLine());
            bool CorrectDay = birthDay == 15;

            do
            {
                switch (birthDay)
                {
                    case 14:
                        Console.WriteLine("Close! Try again:");
                        birthDay = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 16:
                        Console.WriteLine("Close! Try again:");
                        birthDay = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 15:
                        Console.WriteLine("You win!");
                        CorrectDay = true;
                        break;
                    default:
                        Console.WriteLine("Try again:");
                        birthDay = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            } while (!CorrectDay);
            Console.ReadLine();
        }
    }
}
