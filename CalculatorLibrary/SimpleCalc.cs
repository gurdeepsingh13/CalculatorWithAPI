using System;

namespace CalculatorLibrary
{
    public class SimpleCalc
    {
        public decimal addition(decimal leftNumber, decimal rightNumber)
        {
            return leftNumber + rightNumber;
        }
        public decimal subtraction(decimal leftNumber, decimal rightNumber)
        {
            return leftNumber - rightNumber;
        }
        public decimal multiplication(decimal leftNumber, decimal rightNumber)
        {
            return leftNumber * rightNumber;
        }
        public decimal divison(decimal leftNumber, decimal rightNumber)
        { if (rightNumber !=0)
            {
                return leftNumber / rightNumber;
            }
            else
            {
                return decimal.MinValue;
            }
            
        }


        public decimal OperatorSwitch(decimal leftNumber, decimal rightNumber, string operators)
        {
            decimal result;

            // Use a switch statement to do the math.
            switch (operators)
            {
                case "Addition":
                    result = leftNumber + rightNumber;
                    break;
                case "Subtraction":
                    result = leftNumber - rightNumber;
                    break;
                case "Multiplication":
                    result = leftNumber * rightNumber;
                    break;
                case "Division":
                    // Ask the user to enter a non-zero divisor.
                    if (rightNumber != 0)
                    {
                        result = leftNumber / rightNumber;
                    }
                    
                    else
                    {
                        result = decimal.MaxValue;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    result = 0;
                    break;
            }
            return result;
        }
    }

}
