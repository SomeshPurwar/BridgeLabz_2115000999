using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace SchoolandStudentswithCourses_AssociationandAggregation_
{
    class Course
    {
        public string name;
        private List<Student> students;

        public Course(string name)
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
            Console.WriteLine($"Course: {name} has the following students:");
            foreach (var student in students)
            {
                Console.WriteLine($"  Student: {student.name}");
            }
        }
    }
}
