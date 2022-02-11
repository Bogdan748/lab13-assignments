using System;

namespace Lab13_Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = VectorHelper.GetVector();

            Console.WriteLine();
            Console.WriteLine($"Min valuea is: {VectorHelper.RecursiveMin(array)}");
            Console.WriteLine($"To find the value I made {VectorHelper.RecursiveSteps} steps");


        }
    }
}
