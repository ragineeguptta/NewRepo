using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_Array
{
    class Dictionaries
    {
        //key - value
        // Auto - car
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("CEO", "Mango", 66, 200),
                new Employee("Manager", "Apple", 55, 25),
                new Employee("HR", "Banana", 44, 54),
                new Employee("Secreetary", "Lichi", 33, 34),
                new Employee("Lead Developer", "Dragon Fruit", 31, 42),
                new Employee("Intern", "Pinapple", 22, 9)

            };

            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "two" },
                {3, "three" }
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }


            //Update
            string KeyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(KeyToUpdate))
            {
                employeesDirectory[KeyToUpdate] = new Employee("HR", "Eleka", 26, 18);
                Console.WriteLine("Employee with Role/Key {0} was updated!.", KeyToUpdate);
            }
            else
            {
                Console.WriteLine("No Employee found with th Role/Key {0} was updated!.", KeyToUpdate);
            }


            // Remove
            string KeyToRemove = "Intern";
            if (employeesDirectory.Remove(KeyToRemove))
            {
                Console.WriteLine("Employee with Role/Key {0} was Removed!.", KeyToRemove);
            }
            else
            {
                Console.WriteLine("No Employee found with th Role/Key {0} was updated!.", KeyToRemove);
            }


            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                //using ElementAt(i) to return  the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                //priny the key 
                Console.WriteLine("Key: {0}, i is {1}", keyValuePair.Key, i);
                //storing the value in an employee object 
                Employee employeeValue = keyValuePair.Value;
                //printing the properties of the employee object
                Console.WriteLine("Employee Name: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}", employeeValue.Salary);
            }

            string key = "CEO";
            if (employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory[key];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", empl.Name, empl.Role, empl.Salary);
            }
            else
            {
                Console.WriteLine("No employee found with this Key {0}", key);
            }

            Employee result = null;
            //using TryGetValue() it retuens true if the the operation was successful and false otherwise
            if(employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Value Retrived!.");
                Console.WriteLine("Eployee Name: {0}", result.Name);
                Console.WriteLine("Eployee Role: {0}", result.Role);
                Console.WriteLine("Eployee Age: {0}", result.Age);
                Console.WriteLine("Eployee Salary: {0}", result.Salary);
            }
            else
            {
                Console.WriteLine("The key does not exist");
            }

        }

        class Employee
        {
            //few properties like Role, Name, Age and Rate
            public string Role { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public float Rate { get; set; }
            //yearly Salary = rate/h * number of days * number of weeks * number of months
            public float Salary
            {
                get
                {
                    return Rate * 8 * 5 * 4 * 12;
                }
            }
            //simple constructor
            public Employee(string role, string name, int age, float Rate)
            {
                this.Role = role;
                this.Name = name;
                this.Age = age;
                this.Rate = Rate;
            }
        }
    }
}
