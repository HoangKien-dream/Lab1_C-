using System;

namespace Lab1_06
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var i = 2;
            var s = "Hello";
            var d = 9.5;
            Console.WriteLine("i*i: "+i *i);
            Console.WriteLine("s in upper case: "+ s.ToUpper());
            Console.WriteLine("type of d:"+d.GetType());
        }
    }
}