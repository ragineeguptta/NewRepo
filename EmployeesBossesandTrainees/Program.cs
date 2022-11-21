using System;

namespace EmployeesBossesandTrainees
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee vandna = new Employee("Yadav", "Vandna", 60000);
            vandna.Work();
            vandna.Pause();

            Boss dhaval = new Boss("Hirdhav", "Faria", "Dhaval", 1000000);
            dhaval.Lead();

            Trainee sachin = new Trainee(32, 8, "Varma", "Sachin", 10000);
            sachin.Learn();
            sachin.Work();

            Console.ReadKey();
        }
    }
}
