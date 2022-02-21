using System;

namespace Calculator
{
    public class SimpleMath
    {
        public double Calculate(int num1, int num2, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "Add":
                    result = num1 + num2;
                    break;
                case "Sub":
                    result = num1 + num2;
                    break;
                case "Mult":
                    result = num1 * num2;
                    break;
                case "Div":
                    result = num1 / num2;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
