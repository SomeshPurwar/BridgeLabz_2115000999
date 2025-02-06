using System;
using System.Collections.Generic;

namespace CompanyAndDepartmentsComposition
{
    class Department
    {
        public string name;
        private List<Employee> employees;

        public Department(string name)
        {
            this.name = name;
            employees = new List<Employee>();
        }

        public void addEmployee(string employeeName)
        {
            employees.Add(new Employee(employeeName));
        }

        public void showEmployees()
        {
            Console.WriteLine($"Department: {name}");
            foreach (var emp in employees)
            {
                Console.WriteLine($"  Employee: {emp.name}");
            }
        }
    }
}
