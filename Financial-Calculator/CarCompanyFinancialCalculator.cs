using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CarCompanyFinancialCalculator : IFinancialCalculate
    {
        private const decimal CAR_FINANCE_FACTOR = 0.3m;
        private const decimal CAR_BONUS_FACTOR = 0.4m;

        public decimal CalculateAnnualFinances(decimal input)
        {
            return input * 12 * CAR_FINANCE_FACTOR * CAR_BONUS_FACTOR;
        }

        public decimal CalculateMonthlyFinances(decimal input)
        {
            return input * CAR_FINANCE_FACTOR * CAR_BONUS_FACTOR;
        }

        public decimal CalculateWeeklyFinances(decimal input)
        {
            return input * 0.25m * CAR_FINANCE_FACTOR * CAR_BONUS_FACTOR;
        }
    }
}
