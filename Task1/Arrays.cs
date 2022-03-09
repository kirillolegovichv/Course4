using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Arrays
    {
        public static int ReturnMaxValueOfArray(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public static int ReturnMinValueOfArray(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        public static int ReturnIndexOfMinValueOfArray(int[] array)
        {
            int index = 0;
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    index = i;
                    min = array[i];
                }
            }

            return index;
        }

        public static int ReturnIndexOfMaxValueOfArray(int[] array)
        {
            int index = 0;
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    index = i;
                    max = array[i];
                }
            }

            return index;
        }

        public static int ReturnSummElemsOfArrayOfOddIndex(int[] array)
        {
            int summElems = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                summElems += array[i];
            }

            return summElems;
        }

        public static int[] ReturnReversArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            int reverseIndex = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[reverseIndex];
                reverseIndex--;
            }

            return newArray;
        }

        public static int GetCountOddNumbersOfArray(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static int[] SwapFirstAndSecondHalfsOfArray(int[] array)
        {
            int[] halfArray = new int[array.Length / 2];
            for (int i = 0; i < halfArray.Length; i++)
            {
                halfArray[i] = array[i];
            }
            for (int i = 0; i < halfArray.Length; i++)
            {
                array[i] = array[halfArray.Length + i];
            }
            for (int i = halfArray.Length; i < array.Length; i++)
            {
                array[i] = halfArray[i - halfArray.Length];
            }

            return array;
        }

        public static int[] SelectSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }

            return array;
        }


        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                while (j > 0 && array[j] > array[j + 1])
                { 
                    int tmp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = tmp;
                    j--;
                }
            }

            return array;
        }
    }
}
