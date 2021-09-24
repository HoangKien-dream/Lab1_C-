using System;

namespace Exercise_2._3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] Array = new int [12] {29, 82, 42, 46, 54, 65, 50, 42, 5, 94, 19, 34};
            Console.WriteLine("The first occurence of 42 is at index " +System.Array.IndexOf(Array,42));
            Console.WriteLine("The last occurence of 42 is at index "+System.Array.LastIndexOf(Array,42));
            int x = 0;
            while ((x = System.Array.IndexOf(Array,42,x)) >= 0)
            {
                Console.WriteLine("42 found at index "+x);
                ++x;
            }

            x = Array.Length - 1;
            while ((x = System.Array.LastIndexOf(Array,42,x))>=0)
            {
                Console.WriteLine("42 found at index" +x);
                --x;
            }

            Console.WriteLine("Array that before sorted");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("{0} :      {1}",i+1,Array[i]);
            }
            System.Array.Sort(Array);
            Console.WriteLine("Array that after sorted");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("{0} :      {1}",i+1,Array[i]);
            }
            System.Array.Reverse(Array);
            Console.WriteLine("Array that after reverse: ");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("{0} :      {1}",i+1,Array[i]);
            }

            Console.ReadLine();
        }
    }
}