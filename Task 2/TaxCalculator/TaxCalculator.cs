using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.TaxCalculator
{
    public class TaxCalculator : ITaxCalculator
    {
        /*Storing the tax percentages as fields so the logic can be easily changed in the future and new
        taxes can be added as fields */
        private double incomeTaxAmount = 0.1;
        private double socialContributionsAmount = 0.15;

        public TaxCalculator(double salary)
        {
            Salary = salary;
        }

        private double Salary { get; set; }

        //Calculate tax method encapsulates all of the logic for returning the net salary 
        public double CalculateTax()
        {
            if(Salary <= 1000)
            {
                return Salary;
            }
            double taxBase = Salary - 1000;
            double netSalary = Salary - taxBase * incomeTaxAmount;

            double socialContributionsTaxBase = Math.Min(2000, taxBase);
            netSalary -= socialContributionsTaxBase * socialContributionsAmount;

            return netSalary;
        }
    }
}
