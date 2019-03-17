using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nevena_Spasovska_Homework_class07_01
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Manager(string firstName, string lastName, double salary) : base(firstName, lastName)
        {
            Salary = salary;
            Role = Role.Manager;         
        }

        public void AddBonus(double bonus)
        {
            Bonus = bonus;
        }

        public override double GetSalary()
        {
            double ParentValue = base.GetSalary();
            return ParentValue + Bonus;
        }

    }

   
}
