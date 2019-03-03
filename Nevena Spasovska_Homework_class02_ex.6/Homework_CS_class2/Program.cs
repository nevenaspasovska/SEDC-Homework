using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_CS_class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            var firstInput = Console.ReadLine();
            bool firstResult = int.TryParse(firstInput, out int firstNumber);

            if (!firstResult)
                {
                    Console.WriteLine($"You entered {firstInput}, which is not a number");
                    return;
                };


            Console.Write("Enter second number: ");
            var secondInput = Console.ReadLine();
            bool secondResult = int.TryParse(secondInput, out int secondNumber);

            if (!secondResult)
            {
                Console.WriteLine($"You entered a value {secondInput}, which is not a number");
                return;
            }

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"The first number {firstNumber} is bigger then the second number {secondNumber}");
              
                    if (firstNumber % 2 == 0)
                    {
                    Console.WriteLine($"The first bigger number {firstNumber} is an even number");
                    } else
                    {
                    Console.WriteLine($"The first bigger number {firstNumber} is an odd number");
                    }
            } else if (secondNumber > firstNumber)
            {
                Console.WriteLine($"The second number {secondNumber} is bigger then the first number {firstNumber}");
                    if (secondNumber % 2 == 0)
                    {
                    Console.WriteLine($"The second bigger number {secondNumber} is an even number");
                    } else
                    {
                    Console.WriteLine($"The second bigger number {secondNumber} is an odd number");
                    }

            } else
            {
                Console.WriteLine($"The numbers you entered are equal");
                
                if ((firstNumber % 2 == 0) && (secondNumber % 2 == 0))
                {
                    Console.WriteLine($"The first number {firstNumber}, and the second number {secondNumber}, are even numbers");
                } else
                {
                    Console.WriteLine($"The first number {firstNumber} and the second number {secondNumber}, are odd numbers");
                }
                
            }

         
        }
    }
}
