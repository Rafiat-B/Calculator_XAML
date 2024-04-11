using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK13
{
    public static class Calculate
    {
        public static double DoCalculation(double x, double y, string operatorMath)
        {
            double result = 0;
            switch(operatorMath)
            {
                case "/":
                    result = x / y; break;
                case "*":
                    result = x * y; break;
                case "+":
                    result = x + y; break;
                case "-":
                    result = x - y; break;
              
                default:
                    break;
            }
            return result;
        }

    }
}
