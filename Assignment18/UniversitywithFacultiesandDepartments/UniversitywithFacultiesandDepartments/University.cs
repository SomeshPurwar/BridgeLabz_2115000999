using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace UniversitywithFacultiesandDepartments
{
    class University
    {
        public string name;
        private List<Department> departments;

        public University(string name)
        {
            this.name = name;
            departments = new List<Department>();
        }

        public void addDepartment(Department department)
        {
            departments.Add(department);
        }

        public void removeDepartment(Department department)
        {
            departments.Remove(department);
        }

        public void showDepartments()
        {
            Console.WriteLine($"University: {name}");
            foreach (var department in departments)
            {
                department.showFaculties();
            }
        }

        public void deleteUniversity()
        {
            // Deleting the university deletes all departments as well (composition).
            departments.Clear();
            Console.WriteLine($"University {name} has been deleted, along with all its departments.");
        }
    }
}
