using System;
using System.Collections.Generic;

namespace SchoolandStudentswithCourses_AssociationandAggregation_
{
    class School
    {
        public string name;
        private List<Student> students;

        public School(string name)
        {
            this.name = name;
            students=new List<Student>();
        }

        public void addStudent(Student student)
        {
            students.Add(student);
        }

        public void showStudents()
        {
            Console.WriteLine($"School: {name}");
            foreach (var student in students)
            {
                student.viewCourses();
            }
        }
    }
}
