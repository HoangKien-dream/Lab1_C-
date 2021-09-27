using System;
using System.Collections.Generic;

namespace Exercies_5._2.Teacher
{
    public class Teacher: Person.Person
    {
        public string Rank { get; set; }
        public double Salary { get; set; }
        public double Bonus { get; set; }


        public override void AcceptPerson()
        {
            Console.WriteLine("Enter your name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Enter your rank: ");
            Rank = Console.ReadLine();
            Console.WriteLine("Enter your salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your bonus: ");
            Bonus = Convert.ToDouble(Console.ReadLine());
        }
    }
}