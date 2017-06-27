using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Arrays
    {
        public static void printPairs(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    Console.Write(array[i] + "," + array[j]);
                }
            }
        }

        public static void printUnorderedPairs(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    Console.Write(array[i] + "," + array[j]);
                }
            }
        }

        public static void printUnorderedPairs(int[] arrayA, int[] arrayB)
        {
            for (int i = 0; i < arrayA.Length; i++)
            {
                for (int j = 0; j < arrayB.Length; j++)
                {
                    if (arrayA[i] < arrayB[j])
                    {
                        Console.Write(arrayA[i] + "," + arrayB[j]);
                    }
                }
            }
        }

        void reverse(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int other = array.Length - i - 1;
                int temp = array[i];
                array[i] = array[other];
                array[other] = temp;
            }
        }
    }
}
