using System;

namespace Exercies_4._1
{
    public class Factulty: Employee
    {
        public string Hour { get; set; }
        public string Rank { get; set; }

        private int DateNow = 2021;
        public override double CalculateBonus()
        {
            return 1000 + 0.05 * Salary;
        }

        public override void CalculateVacation()
        {
            if (DateNow-DateHide>=3)
            {
                if (Rank.Equals("Senior Lecturer"))
                {
                    Console.WriteLine("He/She have 6 week Vacation. ");
                }
                else
                {
                    Console.WriteLine("He/She have 5 week Vacation. ");
                }
            }
            else
            {
                Console.WriteLine("He/She have 4 week Vacation");
            }
        }
    }
}