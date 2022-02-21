using System;

namespace Calculator
{
    public class SimpleMath
    {
        public double Calculate(int lVal, int rVal, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "Add":
                    result = lVal + rVal;
                    break;
                case "Sub":
                    result = lVal - rVal;
                    break;
                case "Mult":
                    result = lVal * rVal;
                    break;
                case "Div":
                    result = lVal / rVal;
                    break;
                default:
                    break;
            }
            return result;
        }

    }
}
