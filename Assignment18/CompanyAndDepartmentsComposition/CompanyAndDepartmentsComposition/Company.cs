using System;
using System.Collections.Generic;

namespace CompanyAndDepartmentsComposition
{
    class Company
    {
        public string name;
        private List<Department> dept;

        public Company(string name) {
            this.name = name;
            dept=new List<Department>();
        }

        public void addDepartment(string deptName)
        {
            dept.Add(new Department(deptName));
        }

        public void showDepartments()
        {
            Console.WriteLine($"Company: {name}");
            foreach (var d in dept)
            {
                d.showEmployees();
            }
        }

    }
}
