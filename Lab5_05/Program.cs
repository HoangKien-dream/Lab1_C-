using System;
using System.IO;

namespace Lab5_05
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            FileStream outStream = null;
            FileStream inStream = null;
            try
            {
                outStream = File.OpenWrite("kien.txt");
                inStream = File.OpenRead("mai.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
            finally
            {
                if (outStream!=null)
                {
                    outStream.Close();
                    Console.WriteLine("outstream Closed");
                }

                if (inStream!=null){}
                {
                    inStream.Close();
                    Console.WriteLine("instream Closed");
                }
            }
        }
    }
}