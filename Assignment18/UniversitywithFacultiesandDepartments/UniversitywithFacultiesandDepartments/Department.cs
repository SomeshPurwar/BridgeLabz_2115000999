using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace UniversitywithFacultiesandDepartments
{
    class Department
    {
        public string name;
        private List<Faculty> faculties;

        public Department(string name)
        {
            this.name = name;
            faculties = new List<Faculty>();
        }

        public void addFaculty(Faculty facultyName)
        {
            faculties.Add(facultyName);
        }

        public void removeFaculty(Faculty facultyName)
        {
            faculties.Remove(facultyName);
        }

        public void showFaculties()
        {
            Console.WriteLine($"Department: {name} has the following faculty members:");
            foreach (var faculty in faculties)
            {
                Console.WriteLine($"  Faculty: {faculty.name}");
            }
        }
    }
}
