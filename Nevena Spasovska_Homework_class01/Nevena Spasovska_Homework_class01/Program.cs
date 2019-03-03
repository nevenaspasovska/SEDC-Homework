using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nevena_Spasovska_Homework_class01
{
    class Program
    {
        static void Main(string[] args)
        {
            int spaces = 8;
            int asterix = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < asterix; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                asterix++;
                spaces--;
            }
            
        }
    }
}
