using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesBossesandTrainees
{
    class Employee
    {
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public Employee()
        {
            Name = "Gupta";
            FirstName = "Raginee";
            Salary = 50000;
        }

        public void Work()
        {
            Console.WriteLine("I'm a working");
        }
        public void Pause()
        {
            Console.WriteLine("I'm having a break");
        }

    }
}
