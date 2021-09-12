using System;

namespace Exercise__2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] n = new int[3];
            // ReSharper disable once EmptyForStatement
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter your number {0}: ",i+1);
                n[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = n[0];
            for (int i = 1; i < 3; i++)
            {
                if (max < n[i])
                {
                    max = n[i];
                }
            }
            Console.WriteLine("Max: "+max);
        }
    }
}