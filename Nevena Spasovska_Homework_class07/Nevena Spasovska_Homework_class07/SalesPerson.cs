using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nevena_Spasovska_Homework_class07_01
{
    public class SalesPerson : Employee
    {
        private double SuccessSalesRevenue { get; set; }

        public SalesPerson(string firstName, string lastName, double successSalesRevenue) : base(firstName, lastName)
        {
            Salary = 500;
            Role = Role.Sales;
            SuccessSalesRevenue = successSalesRevenue;
        }

        public void AddSuccessRevenue(double number)
        {
            SuccessSalesRevenue = number;
        }

        public override double GetSalary()
        {
            double ParentValue = base.GetSalary();

            if (SuccessSalesRevenue <= 2000)
            {
                return ParentValue += 500;
            }
            else if ((SuccessSalesRevenue > 2000) && (SuccessSalesRevenue < 5000))
            {
                return ParentValue += 1000;
            }
            else if (SuccessSalesRevenue > 5000)
            {
                return ParentValue += 1500;
            }
            else
            {
                return ParentValue;
            }
                
        }

    }
}
