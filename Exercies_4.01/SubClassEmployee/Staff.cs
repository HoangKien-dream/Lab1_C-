using System;

namespace Exercies_4._1
{
    public class Staff: Employee
    {
        public string Title { get; set; }
        private int dateNow = 2021;
        public override double CalculateBonus()
        {
            return 0.06 * Salary;
        }

        public override void CalculateVacation()
        {
            if (dateNow - DateHide >= 5)
            {
                Console.WriteLine("Staff have 4 weeks vocation. ");
            }
            else
            {
                Console.WriteLine("Staff have 3 weeks vocation. ");
            }
        }
    }
}