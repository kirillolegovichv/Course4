using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Variables
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2">number2 != 0</param>
        /// <returns></returns>
        public static double[] GetQuontientAndRemainder(double number1, double number2)
        {
            if (number2 == 0)
            {
                throw new Exception("number2 must be != 0");
            }
            double result = number1 / number2;
            int ost = Convert.ToInt32(number1) % Convert.ToInt32(number2);
            double [] res = new double [2] {result, ost};
            return res;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="number1">mustn`t be equal number2</param>
        /// <param name="number2">mustn`t be equal number1</param>
        /// <returns></returns>
        public static double GetResultOfExpression(double number1, double number2)
        {
            if (number1 == number2)
            {
                throw new Exception("number1 mustn`t be equal number2");
            }
            double result = (5 * number1 + number2 * number2) / (number2 - number1);
            return result;
        }

        public static double[] ChangeNumbers(double number1, double number2)
        {
            double c = number1;
            number1 = number2;
            number2 = c;
            double[] result = new double[2] { number1, number2 };
            return result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">mustn`t be equal 0</param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static double GetXOfLinearEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("'a' mustn`t be equal 0");
            }
            double x = (c - b) / a;
            return x;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="x1">mustn`t be equal x2</param>
        /// <param name="y1">mustn`t be equal x1</param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public static string GetEquation(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {
                throw new Exception("x1 mustn`t be equal x2");
            }
            double a = -(y1 - y2);
            double b = -(x1 * y2 - x2 * y1);
            double c = x2 - x1;
            string result = $"Y = {a / c}X + {b / c}";
            return result;
        }
    }
}
