using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nevena_Spasovska_Homework_class07_01
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public double Salary { get; set; }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

       
    }
}
