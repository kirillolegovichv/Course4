using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class IfElse
    {
        public static string GetResultOfCondition(double number1, double number2)
        {
            string result = "";
            if (number1 > number2)
            {
                result = $"a + b = {number1 + number2}";
            }
            else if (number1 == number2)
            {
                result = $"a * b = {number1 * number2}";
            }
            else 
            {
                result = $"a - b = {number1 - number2}";
            }
            return result;
        }

        public static string GetQuarto(double x, double y)
        {
            string result = "";
            if (x > 0 && y > 0)
            {
                result = "Точка находится в 1 четверти";
            }
            else if (x < 0 && y > 0)
            {
                result = "Точка находится в 2 четверти";
            }
            else if (x < 0 && y < 0)
            {
                result = "Точка находится в 3 четверти";
            }
            else if (x > 0 && y < 0)
            { 
                result = "Точка находится в 4 четверти";
            }
            else
            {
                result = "Точка лежит на оси";
            }
            return result;
        }

        public static double[] Sorted(double number1, double number2, double number3)
        {
            double[] sorted;
            if (number1 >= number2 && number2 >= number3 && number1 >= number3)
            {
                sorted = new double[3] { number3, number2, number1 };
            }
            else if (number1 <= number2 && number2 >= number3 && number1 >= number3)
            {
                sorted = new double[3] { number3, number1, number2 };
            }
            else if (number1 <= number2 && number2 >= number3 && number1 <= number3)
            {
                sorted = new double[3] { number1, number3, number2 };
            }
            else if (number1 <= number2 && number2 <= number3 && number1 <= number3)
            {
                sorted = new double[3] { number1, number2, number3 };
            }
            else if (number1 >= number2 && number2 >= number3 && number1 <= number3)
            {
                sorted = new double[3] { number2, number1, number3 };
            }
            else 
            {
                sorted = new double[3] { number2, number3, number1 };
            }
            return sorted;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">mustn`t be equal 0</param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static double[] GetRootsOfQuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("a == 0, this isn`t quadratic equation");
            }
            double[] result;
            double d = b * b - 4 * a * c;
            if (d < 0)
            { 
                result = new double[0]; 
            }
            if (d == 0)
            {
                result = new double[1] { -b / (2 * a) };
            }
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                result = new double[2] { x1, x2 };
            }
            return result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="number">number must be > 9 and < 100</param>
        /// <returns></returns>
        public static string GetNumberInWords(int number)
        {
            if (number < 10 || number > 99)
            {
                throw new Exception("number must be > 9 and < 100");
            }
            string dec;
            string un;
            string result;
            if (number > 19)
            {
                int decade = number / 10;
                int unit = number % 10;
                if (decade == 2)
                {
                    dec = "двадцать";
                }
                else if (decade == 3)
                {
                    dec = "тридцать";
                }
                else if (decade == 4)
                {
                    dec = "сорок";
                }
                else if (decade == 5)
                {
                    dec = "пятдесят";
                }
                else if (decade == 6)
                {
                    dec = "шестьдесят";
                }
                else if (decade == 7)
                {
                    dec = "семдесят";
                }
                else if (decade == 8)
                {
                    dec = "восемдесят";
                }
                else
                {
                    dec = "девяносто";
                }

                if (unit == 1)
                {
                    un = "один";
                }
                else if (unit == 2)
                {
                    un = "два";
                }
                else if (unit == 3)
                {
                    un = "три";
                }
                else if (unit == 4)
                {
                    un = "четыре";
                }
                else if (unit == 5)
                {
                    un = "пять";
                }
                else if (unit == 6)
                {
                    un = "шесть";
                }
                else if (unit == 7)
                {
                    un = "семь";
                }
                else if (unit == 8)
                {
                    un = "восемь";
                }
                else
                {
                    un = "девять";
                }
                result = $"{dec} {un}";
            }
            else
            {
                if (number == 10)
                {
                    result = "десять";
                }
                else if (number == 11)
                {
                    result = "одиннадцать";
                }
                else if (number == 12)
                {
                    result = "двенадцать";
                }
                else if (number == 13)
                {
                    result = "тринадцать";
                }
                else if (number == 14)
                {
                    result = "четырнадцать";
                }
                else if (number == 15)
                {
                    result = "пятнадцать";
                }
                else if (number == 16)
                {
                    result = "шестнадцать";
                }
                else if (number == 17)
                {
                    result = "семнадцать";
                }
                else if (number == 18)
                {
                    result = "восемнадцать";
                }
                else
                {
                    result = "девятнадцать";
                }
            }
            return result;
        }
    }
}
