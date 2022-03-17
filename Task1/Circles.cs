using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Circles
    {
        public static double GetAInExtendB(double number1, double number2)
        {
            double result = 1;
            for (int i = 1; i <= number2; i++)
            {
                result *= number1;
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number">must be > 0</param>
        /// <returns></returns>
        public static int[] GetSequenceThatMultipleOfA(int number)
        {
            if (number <= 0)
            {
                throw new Exception("Number must be > 0");
            }
            int count = 0;
            for (int i = number; i <= 1000; i += number)
            {
                count++;
            }
            int[] result = new int[count];
            int tmp = 0;
            for (int i = number; i <= 1000; i += number)
            {
                result[tmp] = i;
                tmp++;
            }
            return result;
        }

        public static int ReturnCountOfNumbersWhatSqrtLessThanCurrent(int number)
        {
            int result = 0;

            for (int i = 1; i * i < number; i++)
            {
                result = i;
            }

            return result;
        }

        public static int ReturnLargestDivisor(int number)
        {
            if (number < 0)
            {
                throw new Exception("number must be non antipositive");
            }
            int result = 1;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = i;
                }
            }

            return result;
        }

        public static int ReturnSummOfNumbersWhatDividedBySeven(int number1, int number2)
        {
            int result = 0;

            for (int i = number1; i < number2; i++)
            {
                if (i % 7 == 0)
                {
                    result += i;
                }
            }

            return result;
        }

        public static int ReturnFibonacheNumberByPosition(int  number)
        {
            if (number < 1)
            {
                throw new Exception("number must be > 0");
            }
            int A = 1;
            int B = 1;
            int next;
            for (int i = 3; i <= number; i++)
            {
                next = A + B;
                A = B;
                B = next;
            }

            return B;
        }

        public static int ReturnGreatestCommonDivision(int number1, int number2)
        {
            if (number1 <= 0 || number2 <= 0)
            {
                throw new Exception("numbers must be positive");
            }
            while (number1 != 0 && number2 != 0)
            {
                if (number1 > number2)
                {
                    number1 %= number2;
                }
                else
                {
                    number2 %= number1;
                }
            }

            return number1 + number2;
        }

        public static int ReturnCubicRootOfPositiveNumber(int number)
        {
            if (number <= 0)
            {
                throw new Exception("number must be positive");
            }
            int A = 0;
            int B = number;
            int middle;

            while (B - A != 1)
            {
                middle = (B + A) / 2;
                if ((middle * middle * middle) > number)
                {
                    B = middle;
                }
                else
                {
                    A = middle;
                }

            }

            return A;
        }

        public static int ReturnCountOddNumbersOfNumber(int number)
        {
            int count = 0;

            while (number > 0)
            {
                if (number % 2 != 0)
                {
                    number /= 10;
                    count++;
                }
                else
                {
                    number /= 10;
                }
            }

            return count;
        }

        public static int ReturnReversOfNumber(int number)
        {
            if (number < 0)
            {
                throw new Exception("number must be positive");
            }            
            int result = 0;

            while (number > 0)
            {
                result += number % 10;
                number /= 10;
                if (number != 0)
                {
                    result *= 10;
                }
            }

            return result;
        }

        public static void GetCountOfEvenAndOdd(int i, out int odd, out int even)
        {
            int tmp = i;
            odd = 0;
            even = 0;
            while (tmp > 0)
            {
                if ((tmp % 10) % 2 == 0 && (tmp % 10) != 0)
                {
                    even += tmp;
                }
                else
                {
                    odd += tmp;
                }
                tmp /= 10;
            }
        }
        
        public static int[] ReturnNumbersSummEvenOfThemMoreThanSummOdd(int number)
        {
            int tmp = 0;
            int countOfEven = 0;

            for (int i = 1; i < number; i++)
            {
                int odd;
                int even;
                GetCountOfEvenAndOdd(i, out odd, out even);
                if (even > odd)
                {
                    countOfEven++;
                }
            }

            int[] result = new int[countOfEven];
            int count = 0;

            for (int i = 1; i < number; i++)
            {
                int odd;
                int even;
                GetCountOfEvenAndOdd(i, out odd, out even);
                if (even > odd)
                {
                    result[count] = i;
                    count++;
                }
            }

            return result;
        }

        public static bool ReturnTrueIfSameDigitsInNumbers(int number1, int number2)
        {
            bool result = false;

            while (number1 > 0)
            {
                int tmpForB = number2;
                while (tmpForB > 0)
                {
                    if (number1 % 10 == tmpForB % 10)
                    {
                        result = true;
                    }
                    tmpForB /= 10;
                }
                number1 /= 10;
            }

            return result;
        }
    }
}
