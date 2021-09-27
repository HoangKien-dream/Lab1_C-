using System;

namespace Exercies_5._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Teacher.Teacher teacher = new Teacher.Teacher();
            }
            catch (AmountException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

    internal class AmountException : Exception
    {
        private Teacher.Teacher teacher = new Teacher.Teacher();
    }
}