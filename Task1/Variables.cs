using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Variables
    {
        public static double[] GetQuontientAndRemainder(double number1, double number2)
        {
            double result = number1 / number2;
            int ost = Convert.ToInt32(number1) % Convert.ToInt32(number2);
            double [] res = new double [2] {result, ost};
            return res;
        }

        public static double GetResult(double number1, double number2)
        {
            double result = (5 * number1 + number2 * number2) / (number2 - number1);
            return result;
        }

        public static double[] GetChangeNumbers(double number1, double number2)
        {
            double c = number1;
            number1 = number2;
            number2 = c;
            double[] result = new double[2] { number1, number2 };
            return result;
        }

        public static double GetX(double a, double b, double c)
        {
            double x = (c - b) / a;
            return x;
        }

        public static string GetEquation(double x1, double y1, double x2, double y2)
        {
            double a = -(y1 - y2);
            double b = -(x1 * y2 - x2 * y1);
            double c = x2 - x1;
            string result = $"Y = {a / c}X + {b / c}";
            return result;
        }
    }
}
