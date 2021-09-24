using System;

namespace Lab3_02
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private string address;
        private long sin;
        private double salary;

        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }

        public double CalculateBonus(double percent)
        {
            return salary*(percent/100);
        }

        public override string ToString()
        {
            return string.Format("Name: {0}  LastName: {1}  Address: {2}  Sin: {3}  Salary: {4}  ", firstName, lastName, address, sin, salary);
        }

        public static void Main(string[] args)
        {
            Employee employee = new Employee("Hoang", "Kien", "78 Ngoc Ha",123456,500000);
            Console.WriteLine("---- Information Employee ----");
            Console.WriteLine(employee.ToString() + "Bonus: " +employee.CalculateBonus(50));
        }
    }
}