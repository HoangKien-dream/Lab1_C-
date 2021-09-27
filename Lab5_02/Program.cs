using System;

namespace Lab5_02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            byte[] a = new byte[5];
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("a[{0}] = ", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Khong duoc nhap ki tu cho mang so");
            }
            catch (OverflowException ex1)
            {
                Console.WriteLine("khong duoc nhap gia tri nam ngoai mien tu 0 -> 255");
            }
            catch (IndexOutOfRangeException ex2)
            {
                Console.WriteLine("Loi vuot qua pham vi cua mang");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}", a[i]);
            }
        }
    }
}