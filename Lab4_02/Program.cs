using System;

namespace Exercies_4._2
{
    internal class Program
    {


        class IndexerExample
        {
            public int[] intList = new int [10];

            public int this[int index]
            {
                get { return intList[index]; }
                set { intList[index] = value; }
            }
        }

        class IndexerDemo
        {
            public static void Main(string[] args)
            {
                int i, j = 0;
                IndexerExample indexerExample = new IndexerExample();
                for ( i = 1; i < 10; i+=2)
                {
                    indexerExample[j] = i;
                    j++;
                }

                for ( i = 0; i < 5; i++)
                {
                    Console.WriteLine("indexTest [{0}] is {1}", i, indexerExample[i]);
                    Console.ReadLine();
                }
            }
        }
    }
}