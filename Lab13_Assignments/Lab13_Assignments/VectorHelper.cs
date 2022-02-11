using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Assignments
{
    public static class VectorHelper
    {
        public static int RecursiveSteps = 0;
        public static  int[] GetVector()
        {
            Console.WriteLine("Type values separeted by commas (Ex: '1,2,3')");
            string input = Console.ReadLine();

            int[] array = input.Split(',',StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();

            return array;
        }

        public static int RecursiveMin(int[] array)
        {
            return RecursiveMin(array, 0);
        }

        private static int RecursiveMin(int[] array,int n)
        {
            RecursiveSteps += 1;

            if (array.Length - 1 == n) return array[n];

            return Math.Min(array[n], RecursiveMin(array, n + 1));

        }

        public static int RecursiveSum(int[] array)
        {
            return RecursiveSum(array, 0);
        }

        private static int RecursiveSum(int[] array, int n)
        {
            RecursiveSteps += 1;

            if (array.Length - 1 == n) return array[n];

            return array[n] + RecursiveSum(array, n + 1);

        }


    }
}
