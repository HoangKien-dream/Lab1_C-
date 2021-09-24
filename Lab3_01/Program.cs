using System;
using System.Collections.Generic;

namespace Lab3_01
{
    internal class Program
    {
        List<Program> list = new List<Program>();
        public int number { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public float weight { get; set; }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", number, symbol, name, weight);
        }

        public  bool Accept()
        {
            Console.WriteLine("Atomic Information");
            Console.WriteLine("===================");
            while (true)
            {
                Program program = new Program();
                Console.WriteLine("Enter atomic number: ");
                program.number = Convert.ToInt32(Console.ReadLine());
                if (program.number!=0)
                {
                    Console.WriteLine("Enter symbol: ");
                   program.symbol = Console.ReadLine(); 
                    Console.WriteLine("Enter full name:  ");
                   program.name = Console.ReadLine();
                    Console.WriteLine("Enter atomic weight: ");
                    program.weight = Convert.ToSingle(Console.ReadLine());
                   list.Add(program);
                }
                else
                {
                    Console.WriteLine("No Sym Name Weight");
                    Console.WriteLine("--------------------------------");
                    break;
                }
            }
            return true;
        }

        public void Display()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());   
            }
        }
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Accept();
            program.Display();
        }
    }
}