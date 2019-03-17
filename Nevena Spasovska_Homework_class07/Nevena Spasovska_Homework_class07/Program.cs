using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nevena_Spasovska_Homework_class07_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Nevena", "Spasovska", 5000);
            manager.AddBonus(7000);
            Console.WriteLine(manager.GetSalary());


            SalesPerson salesPerson = new SalesPerson("Nevena", "Spasovska", 3000);
            salesPerson.AddSuccessRevenue(7000);
            Console.WriteLine(salesPerson.GetSalary());

        }
    }
}
