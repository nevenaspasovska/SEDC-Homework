using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nevena_Spasovska_Homework_class02_ex._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number from 1 to 3: ");
            string input = Console.ReadLine();
            bool Parse = int.TryParse(input, out int inputNumber);

            if(!Parse)
            {
                Console.WriteLine("It is not a valid number");
            }

            switch (inputNumber)
            {
                case 1:
                    Console.WriteLine("You got a new car");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike");
                    break;
                default:
                    Console.WriteLine("Not a number in the range from 1 to 3");
                    break;
            }


        }
    }
}
