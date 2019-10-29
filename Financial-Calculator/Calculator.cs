using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        private static decimal firstNumber = 0;
        private static decimal secondNumber = 0;
        private static decimal result = 0;

        public static Decimal AddNumbers(String firstNumberString, String secondNumberString)
        {

            if (Decimal.TryParse(firstNumberString, out firstNumber) & Decimal.TryParse(secondNumberString, out secondNumber))
            {
                result = firstNumber + secondNumber;
            }
            return result;
        }

        public static Decimal SubtractNumbers(String firstNumberString, String secondNumberString)
        {
            if (Decimal.TryParse(firstNumberString, out firstNumber) & Decimal.TryParse(secondNumberString, out secondNumber))
            {
                result = firstNumber - secondNumber;
            }
            return result;
        }

        public static Decimal DivideNumbers(String firstNumberString, String secondNumberString)
        {
            if (Decimal.TryParse(firstNumberString, out firstNumber) & Decimal.TryParse(secondNumberString, out secondNumber))
            {
                try {result = firstNumber / secondNumber;}
                catch(DivideByZeroException) { Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("Cannot divide by zero!");}
            }
            return result;
        }

        public static Decimal MultiplyNumbers(String firstNumberString, String secondNumberString)
        {
            if (Decimal.TryParse(firstNumberString, out firstNumber) & Decimal.TryParse(secondNumberString, out secondNumber))
            {
                if (secondNumber == 0) { Console.WriteLine("Multiplication with zero always returns zero"); } else {
                    Console.BackgroundColor = ConsoleColor.Black;
                    result = firstNumber * secondNumber;
                }
            }
            return result;
        }

    }
}
