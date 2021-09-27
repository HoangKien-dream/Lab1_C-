using System;

namespace Exercies_4._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Factulty employee = new Factulty();
            employee.Name = "Hoang Kien";
            employee.Email = "hoangkien@gmail.com";
            Console.WriteLine(employee.ToString());
            employee.Salary = 500000;
            Console.WriteLine(employee.CalculateBonus());
            employee.DateHide = 2020;
            employee.Rank = "Senior Lecturers";
            employee.CalculateVacation();
            Console.WriteLine("============================");
            Staff staff = new Staff();
            staff.Name = "Thanh Mai";
            staff.Email = "thanhmai@gmail.com";
            Console.WriteLine(staff.ToString());
            staff.Salary = 800000;
            Console.WriteLine(staff.CalculateBonus());
            staff.DateHide = 2010;
            staff.CalculateVacation();

        }
    }
}