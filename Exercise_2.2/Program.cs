using System;

namespace Exercise_2._2
{
    internal class Program
    {
        private int empID;

        public Program(int empId)
        {
            empID = empId;
        }

        public override string ToString()
        {
            return empID.ToString();
        }
    }

    class ObjectArray
    {
        public void Run()
        {
            int[] IntArray;
            Program[] empArray;
            IntArray = new int[5];
            empArray = new Program[3];
            for (int i = 0; i < empArray.Length; i++)
            {
                empArray[i] = new Program(i + 5);
            }

            Console.WriteLine("The int array: ");
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.WriteLine(IntArray[i].ToString());
            }

            Console.WriteLine("\nThe employee Array....");
            for (int i = 0; i < empArray.Length; i++)
            {
                Console.WriteLine(empArray.ToString());
            }
        }
        static void Main(string[] args)
        {
            ObjectArray arr = new ObjectArray();
            arr.Run();
            Console.ReadLine();
        }
    }
    
}