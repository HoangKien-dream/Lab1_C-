using System;

namespace Lab1_04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Currency formating -  {0:C}      {1:C4}", 00.8, 888.8);
            Console.WriteLine("Integer formating - {0:D5}", 88);
            Console.WriteLine("Exponential formating - {0:E}", 888.8);
            Console.WriteLine("Fixed-point formating - {0:F3}", 888.8888);
            Console.WriteLine("General formating - {0:G}", 888.8888);
            Console.WriteLine("Number formating - {0:N}", 8888888.8);
            Console.WriteLine("Hexadecimal formating - {0:X4}", 88);
        }
    }
}