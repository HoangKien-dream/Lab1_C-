using System;

namespace Lab5_03
{
       public class InvalidInput : ApplicationException
       {
              public InvalidInput() : base("Enter a number greater than zero"){}
       }

       class TextExcep
       {
              public static void Main(string[] args)
              {
                     int intCnt;
                     int intNum = 0;
                     Console.WriteLine("Enter a number : ");
                     try
                     {
                            intNum = Convert.ToInt32(Console.ReadLine());
                            if (intNum < 0)
                            {
                                   throw new InvalidInput();
                            }
                     }
                     catch (InvalidInput e)
                     {
                            Console.WriteLine(e.Message);
                            throw;
                     }
                     catch (System.FormatException e1)
                     {
                            Console.WriteLine(e1.Message);
                     }
                     finally
                     {
                            if (intNum > 0)
                            {
                                   for (intCnt = 1;intCnt  <= 10; intCnt++)
                                   {
                                          Console.WriteLine(intCnt*intNum);
                                   }
                            }

                            Console.ReadLine();
                     }
              }
       }
}