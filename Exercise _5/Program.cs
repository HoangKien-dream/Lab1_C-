using System;

namespace Exercise__5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            long num = 1;
            for (int i = 1; i < 21; i++)
            {
                num = num * i;
            }
            Console.WriteLine("20! = "+num);
        }
    }
}