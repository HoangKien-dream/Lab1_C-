using System;

namespace Lab5_04
{
    internal class Program
    {
        public static int AnExceptionFunction(int values)
        {
            if (values==0)
            {
                throw new DivideByZeroException("Divied By 0 error !");
            }
            int x = 20;
            return x;  
        }
        public static void Main(string[] args)
        {
            int value = 0;
            try
            {
                value = AnExceptionFunction(10);
                Console.WriteLine("Value  = {0}",value);
                AnExceptionFunction(0);
                Console.WriteLine("Value = {0}",value);
            }
            catch (Exception e) 
            {
                Console.WriteLine("Caught an exception {0}. Continuing", e);
                throw;
            }

            Console.WriteLine("Done");
        }
    }
}