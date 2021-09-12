using System;

namespace Exercise__1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Please enter your phone: ");
            string phone = Console.ReadLine();
            Console.WriteLine("------Information------");
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Address: "+address);
            Console.WriteLine("Phone: "+phone);
        }
    }
}