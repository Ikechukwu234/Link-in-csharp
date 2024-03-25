using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link_in_csharp
{
    internal class Music
    {
        class Employee
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Department { get; set; }

            public int Salary { get; set; }

        }

        public void ManipulateMusic()
        {
            IEnumerable<Employee> employees = new List<Employee>()
            {

                new Employee {Id = 1, Name = "Bosco", Department="Music", Salary= 900},
                new Employee {Id = 9, Name = "Praise", Department="Music", Salary= 10000},
                new Employee {Id = 7, Name = "Winner", Department="Music", Salary= 2700}

            };

            Console.WriteLine("");
            Console.WriteLine("The Music employees and their salaries are as follows: ");
            var employeeSalaries = employees.OrderByDescending(emp => emp.Salary);
            foreach (var employeeSalary in employeeSalaries)
            {
                Console.WriteLine($"{employeeSalary.Name} : {employeeSalary.Salary}");
            }
        }
    }
}
