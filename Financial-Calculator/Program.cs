using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCompanyFinancialCalculator carCompanyFinancialCalculator = new CarCompanyFinancialCalculator();
            TreeCompanyFinancialCalculator treerCompanyFinancialCalculator = new TreeCompanyFinancialCalculator();

            decimal annualResult = CarCompanyFinancialCalculator.CalculateAnnualFinances(20000m);
        }

    }
}
