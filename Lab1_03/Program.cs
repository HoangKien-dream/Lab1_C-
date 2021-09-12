using System;

namespace Lab1_03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int valueVal = 5;
            test(valueVal);
            Console.WriteLine("The value of the variable is {0}", valueVal);
            Console.ReadLine();
        }

        static void test(int value)
        {
            int temp = 5;
            value = temp * 2;
        }
    }
}