using System;

namespace Lab1_02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int intVal;
            double doubleVal;
            string stringVal;
            intVal = 10;
            doubleVal = 19.96;
            stringVal = "Hello C#";
            Console.WriteLine("{0} is an integer values", intVal);
            Console.WriteLine("{0} is an double values", doubleVal);
            Console.WriteLine("{0} is an string values", stringVal);
            Console.ReadLine();
        }
    }
}