using System;

namespace Lab01_7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var p1 = new {Name = "A", Price = "3"};
            Console.WriteLine("Name = {0}\nPrice = {1}", p1.Name, p1.Price);
            Console.ReadLine();
        }
    }
}