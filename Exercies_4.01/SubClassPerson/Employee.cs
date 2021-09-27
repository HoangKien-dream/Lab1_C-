using System;

namespace Exercies_4._1
{
    public abstract class Employee: Person
    {
        public string Department { get; set; }
        public double Salary { get; set; }
        public int DateHide { get; set; }

        
        
        public abstract double CalculateBonus();

        public abstract void CalculateVacation();
        
        public override string ToString()
        {
            return "NamePerson: " + Name + " Email: " + Email;
        }

    }
}