using System;

namespace Lab1_03._2
{
    class References
    {
        public int valueVal;
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
           References refer = new References();
           refer.valueVal = 5;
           Test(refer);
           Console.WriteLine("The value of the variable is {0}", refer.valueVal);
           Console.ReadLine();
        }

        static void Test(References references)
        {
            int temp = 5;
            references.valueVal = temp * 2;
        }
    }
}