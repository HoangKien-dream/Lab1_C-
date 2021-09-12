using System;

namespace Exercise_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------Table Day-------");
            Console.WriteLine("1. Monday");
            Console.WriteLine("2. Tuesday");
            Console.WriteLine("3. Wednesday");
            Console.WriteLine("4. Thursday");
            Console.WriteLine("5. Friday");
            Console.WriteLine("6. Saturday");
            Console.WriteLine("7. Sunday");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Please enter your choice (1-7): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("1-Monday.");
                    break;
                case 2:
                    Console.WriteLine("2-Tuesday.");
                    break;
                case 3:
                    Console.WriteLine("3-Wednesday.");
                    break;
                case 4:
                    Console.WriteLine("4-Thursday.");
                    break;
                case 5:
                    Console.WriteLine("5-Friday.");
                    break;
                case 6:
                    Console.WriteLine("6-Saturday.");
                    break;
                case 7:
                    Console.WriteLine("7-Sunday.");
                    break;
            }
        }
    }
}