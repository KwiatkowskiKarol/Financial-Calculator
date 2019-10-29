using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class TreeCompanyFinancialCalculator : IFinancialCalculate
    {
        private const decimal TREE_FINANCE_FACTOR = 0.3m;

        public decimal CalculateAnnualFinances(decimal input)
        {
            return input * 12 * TREE_FINANCE_FACTOR;
        }

        public decimal CalculateMonthlyFinances(decimal input)
        {
            return input * TREE_FINANCE_FACTOR;
        }

        public decimal CalculateWeeklyFinances(decimal input)
        {
            return input * 0.25m * TREE_FINANCE_FACTOR;
        }
    }
}
